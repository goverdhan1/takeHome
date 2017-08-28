using System;
using System.Collections.Generic;
using System.Text;

namespace TakeHome.Logic
{
    public static class LogicAndDataAccess
    {
        public static List<EmployeeCase> GetApprovedCases()
        {
            
        }

        public static List<Employee> GetAllEmployees()
        {

        }

        public static Employee GetEmployeeById(long id)
        {

        }

        public static EmployeeCase CreateCase(long employeeId, DateTime startDate, DateTime endDate)
        {
            EmployeeCase theCase = new EmployeeCase()
            {
                StartDate = startDate,
                EndDate = endDate,
                EmployeeId = employeeId
            };

            theCase.GenerateCaseNumber();
            theCase.CalculateApprovedTime();

            // save the case

            return theCase;
        }
    }
}
