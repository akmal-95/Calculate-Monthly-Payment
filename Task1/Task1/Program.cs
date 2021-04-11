using System;
using System.Collections.Generic;
using System.Linq;


namespace Task1
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine("Task 1");
			Console.WriteLine("Basic");
			Console.WriteLine(basic(500000,4.65,30,90).ToString("The Monthly Repayment is RM #.00"));
		}

		public static double basic(double amount, double rate, double duration, double percent)
        {
			double pay = 0;
			rate = rate / 100;
			percent = percent / 100;
			duration = duration * 12;
			double amountpercentage = amount * percent;
			pay = ((amountpercentage) * Math.Pow((rate / 12) + 1, (duration)) * rate / 12) / (Math.Pow(rate / 12 + 1, (duration)) - 1);
			return pay;
		}
	}
}
