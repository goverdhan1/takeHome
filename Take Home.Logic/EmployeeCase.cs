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
        public long? Id { get; set; }

        /// <summary>
        /// The Id of the Employee this case belongs to
        /// </summary>
        public long EmployeeId { get; set; }

        /// <summary>
        /// The unique case number
        /// </summary>
        public string CaseNumber { get; set; }


        /// <summary>
        /// The backing field for StartDate
        /// </summary>
        private DateTime? _StartDate { get; set; }

        /// <summary>
        /// The start date of the case
        /// </summary>
        public DateTime? StartDate
        {
            get
            {
                return _StartDate;
            }
            set
            {
                if (EndDate.HasValue && value > EndDate.Value)
                    throw new ArgumentOutOfRangeException("Start Date must be before End Date");

                _StartDate = value;
            }
        }

        /// <summary>
        /// The backing field for the end date
        /// </summary>
        private DateTime? _EndDate { get; set; }

        /// <summary>
        /// The end date of the case
        /// </summary>
        public DateTime? EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                if (StartDate.HasValue && value < StartDate.Value)
                    throw new ArgumentOutOfRangeException("End Date must be after Start Date");

                _EndDate = value;

            }
        }

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
