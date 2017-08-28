using System;
using System.Collections.Generic;
using System.Text;

namespace TakeHome.Logic
{
    public class EmployeeCase
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Id of the Employee this case belongs to
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The first name of the employee this case belongs to
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the employee this case belongs to
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The unique case number
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// The Start Date of the case
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the case
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Whether any portion of the case is approved
        /// </summary>
        public bool Approved { get; set; }

        /// <summary>
        /// Whether any portion of the case is denied
        /// </summary>
        public bool Denied { get; set; }

        /// <summary>
        /// Generates a unique case number
        /// </summary>
        public void GenerateCaseNumber()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the approved time on this case
        /// </summary>
        public void CalculateApprovedTime()
        {
            throw new NotImplementedException();
        }
    }
}
