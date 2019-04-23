using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2
{
	public class Bank
	{
		static double _interestRate;
		public static double calculateYearlyInterest(Account account)
		{
			if (account.balance > 0.00 && account.balance <= 100.00)
			{
				_interestRate = 1.03;
			}

			if (account.balance > 100 && account.balance <= 1000)
			{
				_interestRate = 1.05;
			}

			if (account.balance > 1000)
			{
				_interestRate = 1.07;
			}					
			return account.balance * _interestRate; ;
		}
	}
}
