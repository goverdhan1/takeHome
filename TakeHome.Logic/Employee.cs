using System;

namespace TakeHome.Logic
{
    public class Employee
    {
        /// <summary>
        /// The unique database id for the employee
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the employee
        /// </summary>
        public string FirstName { get; set; } 

        /// <summary>
        /// The last name of the employee
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The employee number
        /// </summary>
        public string EmployeeNumber { get; set; }
    }
}
