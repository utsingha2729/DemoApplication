﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApplicationForGITHUB.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult CreateEmployee()
        {
            return View();
        }
    }
}