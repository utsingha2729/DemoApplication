﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApplicationForGITHUB.Models
{
	public class Employee
	{
		public int EmployeeID { get; set; }
		public string EmployeeName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime DateOfJoining { get; set; }
        public char Gender { get; set; }
    }
}