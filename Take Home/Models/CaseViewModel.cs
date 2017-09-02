using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeHome.Logic;

namespace TakeHome.Models
{
    public class CaseViewModel
    {
        public CaseViewModel()
        {

        }

        public CaseViewModel(EmployeeCase theCase)
            :this()
        {
            if (theCase == null)
                return;

            Id = theCase.Id;
            EmployeeId = theCase.EmployeeId;
            FirstName = theCase.FirstName;
            LastName = theCase.LastName;
            CaseNumber = theCase.CaseNumber;
            StartDate = theCase.StartDate;
            EndDate = theCase.EndDate;
            Approved = theCase.Approved;
            Denied = theCase.Denied;
        }

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
        /// The start date of the case
        /// </summary>
        public DateTime? StartDate {get; set; }

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

    }
}