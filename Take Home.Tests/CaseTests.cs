using Insight.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TakeHome.Logic;

namespace Take_Home.Tests
{
    [TestClass]
    public class CaseTests
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var dataDirectory = Path.Combine(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, "Take Home\\App_Data");
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
            SqlInsightDbProvider.RegisterProvider();
        }


        [TestMethod]
        public void CaseNumberIsAlphaNumericOnly()
        {
            EmployeeCase theCase = new EmployeeCase();
            theCase.GenerateCaseNumber();
            
            Assert.IsNotNull(theCase.CaseNumber);

            Regex r = new Regex("^[a-zA-Z0-9]*$");
            Assert.IsTrue(r.IsMatch(theCase.CaseNumber));
        }

        [TestMethod]
        public void CaseNumberIsTenCharactersExactly()
        {
            EmployeeCase theCase = new EmployeeCase();
            theCase.GenerateCaseNumber();
            Assert.AreEqual(10, theCase.CaseNumber.Length);
        }

        [TestMethod]
        public void CaseNumberIsNotDuplicate()
        {
            EmployeeCase firstCase = LogicAndDataAccess.CreateCase(1, DateTime.UtcNow, DateTime.UtcNow.AddDays(7));
            EmployeeCase secondCase = LogicAndDataAccess.CreateCase(1, DateTime.UtcNow, DateTime.UtcNow.AddDays(7));
            Assert.AreNotEqual(firstCase.CaseNumber, secondCase.CaseNumber);
        }

        [TestMethod]
        public void ThirteenWeekCaseIsApprovedAndDenied()
        {
            EmployeeCase theCase = LogicAndDataAccess.CreateCase(1, new DateTime(2017, 1, 2), new DateTime(2017, 3, 31));
            Assert.IsTrue(theCase.Approved);
            Assert.IsTrue(theCase.Denied);
        }

        [TestMethod]
        public void OneWeekCaseIsApproved()
        {
            EmployeeCase theCase = LogicAndDataAccess.CreateCase(1, new DateTime(2017, 1, 2), new DateTime(2017, 1, 6));
            Assert.IsTrue(theCase.Approved);
            Assert.IsFalse(theCase.Denied);
        }

        [TestMethod]
        public void SecondCaseIsApprovedAndDenied()
        {
            // 11 week case
            EmployeeCase firstCase = LogicAndDataAccess.CreateCase(1, new DateTime(2017, 1, 2), new DateTime(2017, 3, 17));
            Assert.IsTrue(firstCase.Approved);
            Assert.IsFalse(firstCase.Denied);

            // two week case
            EmployeeCase secondCase = LogicAndDataAccess.CreateCase(1, new DateTime(2017, 3, 20), new DateTime(2017, 3, 31));
            Assert.IsTrue(secondCase.Approved);
            Assert.IsTrue(secondCase.Denied);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Start Date must be before End Date")]
        public void CreateCaseThrowsExceptionIfStartDateIsBeforeEndDate()
        {
            LogicAndDataAccess.CreateCase(1, new DateTime(2017, 3, 20), new DateTime(2017, 3, 19));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "EmployeeId must be positive")]
        public void CreateCaseThrowsExceptionsIfEmployeeIdIsNegative()
        {
            LogicAndDataAccess.CreateCase(-1, new DateTime(2017, 3, 20), new DateTime(2017, 3, 21));
        }

        [TestMethod]
        public void EightEmployeesExistInTheDatabase()
        {
            List<Employee> employees = LogicAndDataAccess.GetAllEmployees();
            Assert.IsNotNull(employees);
            Assert.AreEqual(8, employees.Count);
        }

    }
}
