using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TakeHome.Models
{
    /// <summary>
    /// Container view model to hold list of cases and employees
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// List of cases
        /// </summary>
        public List<CaseViewModel> Cases { get; set; }

        /// <summary>
        /// List of employees
        /// </summary>
        public List<EmployeeViewModel> Employees { get; set; }
    }
}