using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome.Logic
{
    public interface IDataAccess
    {
        /// <summary>
        /// Retrieves all approved cases from the database
        /// </summary>
        /// <returns></returns>
        List<EmployeeCase> ViewApprovedCases();

        /// <summary>
        /// Retrieves all employees from the database
        /// </summary>
        /// <returns></returns>
        List<Employee> ViewAllEmployees();

        /// <summary>
        /// Gets one employee by their id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Employee ViewEmployeeById(int id);

        /// <summary>
        /// Gets all the cases for the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<EmployeeCase> ViewCasesForEmployee(int id);
    }
}
