using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Logic;
using TakeHome.Models;

namespace Take_Home.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        /// <summary>
        /// View an employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Index(int? id)
        {
            //Employee employeeData = null;
            //if(id.HasValue)
            //    employeeData = LogicAndDataAccess.ViewEmployeeById(id.Value);

            //// Translate employee data to view model
            //EmployeeViewModel viewModel = new EmployeeViewModel(employeeData);

            if (id.HasValue)
            {
                CaseListViewModel caseList = new CaseListViewModel();
                caseList.Employee = LogicAndDataAccess.ViewEmployeeById(id.Value);
                caseList.caseList = LogicAndDataAccess.ViewCasesForEmployee(id.Value);
                return View(caseList);
            }
            return Content("An error occured. Please try again");
        }
        
        /// <summary>
        /// End Point to create a case for an employee
        /// </summary>
        /// <param name="newCase"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult CreateCase(CaseViewModel newCase)
        {
            EmployeeCase theCase = LogicAndDataAccess.CreateCase(newCase.EmployeeId, newCase.StartDate.Value, newCase.EndDate.Value);
            newCase.Approved = theCase.Approved;
            newCase.Denied = theCase.Denied;
            return Json(newCase);
        }
    }
}