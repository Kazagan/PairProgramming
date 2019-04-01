using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PairProgramming.Models
{
	public class PayRoll : Employee
	{
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:c}")]
		public double StandardPay
		{
			get
			{
				if (this.Hours_Worked > 40)
				{
					double x = (double)this.Pay_Rate;
					return Math.Round((x * 40), 2);
				}
				else
				{
					double x = (double)this.Pay_Rate;
					return Math.Round((x * this.Hours_Worked), 2);
				}
			}
		}
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
		public double OvertimePay
		{
			get
			{
				if (this.Hours_Worked > 40)
				{
					double overtimeHours = this.Hours_Worked - 40;
					double overtimeRate = (double)this.Pay_Rate * 1.5;
					return Math.Round((overtimeHours * overtimeRate), 2);
				}
				else return 0;
			}
		}
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
		public double TotalPay
		{
			get
			{
				return StandardPay + OvertimePay;
			}
		}
		
	}
}