using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TakeHome.Models;
using TakeHome.Logic;

namespace Take_Home.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Home Page to view all employees and approved cases
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                Employees = LogicAndDataAccess.GetAllEmployees().Select(e => new EmployeeViewModel(e)).ToList(),
                Cases = LogicAndDataAccess.ViewApprovedCases().Select(c =>  new CaseViewModel(c)).ToList()
            };

            return View(homeViewModel);
        }
    }
}