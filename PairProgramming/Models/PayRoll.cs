using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PairProgramming.Models
{
	public class PayRoll : Employee
	{
		public double StandardPay
		{
			get
			{
				if (this.Hours_Worked > 40)
				{
					double x = (double)this.Pay_Rate;
					return x * 40;
				}
				else
				{
					double x = (double)this.Pay_Rate;
					return x * this.Hours_Worked;
				}
			}
		}
		public double OvertimePay
		{
			get
			{
				if (this.Hours_Worked > 40)
				{
					double overtimeHours = this.Hours_Worked - 40;
					double overtimeRate = (double)this.Pay_Rate * 1.5;
					return overtimeHours * overtimeRate;
				}
				else return 0;
			}
		}

		public double TotalPay
		{
			get
			{
				return StandardPay + OvertimePay;
			}
		}
	}
}