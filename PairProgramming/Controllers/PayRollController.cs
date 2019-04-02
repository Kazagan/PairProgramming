using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PairProgramming.Models;

namespace PairProgramming.Controllers
{
    public class PayRollController : Controller
    {
		private PairProgrammingDBEntities db = new PairProgrammingDBEntities();
		private List<Employee> Employees = new List<Employee>();
										   // GET: PayRoll
		public ActionResult Index()
        {
			List<PayRoll> payRolls = PayRollList();
			double sum = 0;
			foreach(var p in payRolls)
			{
				sum += p.TotalPay;
			}
			payRolls.Sum(x=>x.TotalPay);
			ViewBag.Message = $"{sum:c}";
            return View(PayRollList());
        }
		public PayRollController()
		{
			Employees = db.Employees.ToList();
		}
		private List<PayRoll> PayRollList()
		{
			List<PayRoll> payRolls = new List<PayRoll>();
			foreach (Employee employee in Employees)
			{
				payRolls.Add(new PayRoll { EmployeeID = employee.EmployeeID,
										   Employee_Name = employee.Employee_Name,
										   Hours_Worked = employee.Hours_Worked,
										   Pay_Rate = employee.Pay_Rate
										   
				});
			}
			return payRolls;
		}
	}
}