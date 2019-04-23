using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestAssignment2.Test
{
    public class BankTests
    {
			public Random r = new Random();

			[Fact]
	    public void TestBank3PercentInterestRate()
			{
				bool randomBoolean = r.Next(100) % 2 == 0;
				Account testAccountMax = new Account();
				testAccountMax.balance = 100.00;
				Account testAccountMin = new Account();
				testAccountMin.balance = 00.00;
				Account TestAccountRandomNumber = new Account();
				TestAccountRandomNumber.balance = Convert.ToDouble(r.Next(0, 100));

				// Arrange

				var expectedMax = testAccountMax.balance * 1.03;
				var expectedMin = testAccountMin.balance * 1.03;
			// Act

				var actualMax = Bank.calculateYearlyInterest(testAccountMax);
				var actualMin = Bank.calculateYearlyInterest(testAccountMin);

				Assert.Equal(expectedMax, actualMax);
				Assert.Equal(expectedMin, actualMin);
				Assert.InRange(TestAccountRandomNumber.balance, testAccountMin.balance, testAccountMax.balance);
				Assert.NotSame(testAccountMin, testAccountMax);
				Assert.True(randomBoolean);
			
			}

			[Fact]
	    public void TestBank5PercentInterestRate()
	    {
				Account testAccountMax = new Account();
		    testAccountMax.balance = 1000.00;
		    Account testAccountMin = new Account();
		    testAccountMin.balance = 100.01;

		    // Arrange

		    double expectedMax = testAccountMax.balance * 1.05;
		    double expectedMin = testAccountMin.balance * 1.05;
		    // Act

		    double actualMax = Bank.calculateYearlyInterest(testAccountMax);
		    double actualMin = Bank.calculateYearlyInterest(testAccountMin);

		    Assert.Equal(expectedMax, actualMax);
		    Assert.Equal(expectedMin, actualMin);

		}
	    [Fact]
		public void TestBank7PercentInterestRate()
	    {
			
		    Account testAccountMin = new Account();
		    testAccountMin.balance = 1000.01;

		    // Arrange

		    double expectedMin = testAccountMin.balance * 1.07;
		    // Act

		    double actualMin = Bank.calculateYearlyInterest(testAccountMin);

		    Assert.Equal(expectedMin, actualMin);

		}


	}
}
