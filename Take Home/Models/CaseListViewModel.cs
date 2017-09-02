using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakeHome.Logic;

namespace TakeHome.Models
{
    public class CaseListViewModel
    {
      
            public CaseListViewModel()
            {

            }

            public CaseListViewModel(List<EmployeeCase> CaseList, Employee employee)
                : this()
            {
                if (caseList == null || employee == null)
                    return;

            this.caseList = CaseList;
            this.Employee = employee;
            }

            public List<EmployeeCase> caseList { get; set; }
            public Employee Employee { get; set; }

        }
    }
