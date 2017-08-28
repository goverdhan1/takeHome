using Insight.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace TakeHome.Logic
{
    /// <summary>
    /// All logic and data access for this take home project
    /// </summary>
    public static class LogicAndDataAccess
    {
        /// <summary>
        /// The database connection
        /// </summary>
        private static IDataAccess Database { get; set; }

        /// <summary>
        /// Initializes the database connection
        /// </summary>
        static LogicAndDataAccess()
        {
            SqlInsightDbProvider.RegisterProvider();
            DbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AbsenceSoft"].ConnectionString);
            Database = connection.As<IDataAccess>();
        }

        /// <summary>
        /// Returns all the approved cases in the database
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeCase> ViewApprovedCases()
        {
            return Database.ViewApprovedCases();
        }

        /// <summary>
        /// Returns all employees in the database
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetAllEmployees()
        {
            return Database.ViewAllEmployees();
        }

        /// <summary>
        /// Retrieves all employees by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Employee ViewEmployeeById(int id)
        {
            return Database.ViewEmployeeById(id);
        }

        /// <summary>
        /// Retrieves all cases for a specific employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<EmployeeCase> ViewCasesForEmployee(int id)
        {
            return Database.ViewCasesForEmployee(id);
        }

        /// <summary>
        /// Creates a case for the given employee and dates
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static EmployeeCase CreateCase(int employeeId, DateTime startDate, DateTime endDate)
        {
            EmployeeCase theCase = new EmployeeCase()
            {
                StartDate = startDate,
                EndDate = endDate,
                EmployeeId = employeeId
            };

            theCase.GenerateCaseNumber();
            theCase.CalculateApprovedTime();

            throw new NotImplementedException("Employee Case Save Is Not Implemented");

            return theCase;
        }
    }
}
