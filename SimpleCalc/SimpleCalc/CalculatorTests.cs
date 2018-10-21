using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalc
{
	[TestFixture]
	public class CalculatorTests
	{
		[Test]
		public void TestCsAddition()
		{
			Calculator calc = new Calculator();
			calc.Number1 = 10;
			calc.Number2 = 10;
			double answer = calc.Add();
			//Ensure that 10+10=20
			Assert.AreEqual(answer, 20d);
		}

		[Test]
		public void TestCsSubtraction()
		{
			Calculator calc = new Calculator();
			calc.Number1 = 10;
			calc.Number2 = 10;
			double answer = calc.Subtract();
			//Ensure that 10-10=0
			Assert.AreEqual(answer, 0d);
		}

		[Test]
		public void TestCsMultiplication()
		{
			Calculator calc = new Calculator();
			calc.Number1 = 10;
			calc.Number2 = 10;
			double answer = calc.Multiply();
			//Ensure that 10*10=100
			Assert.AreEqual(answer, 100d);
		}

		[Test]
		public void TestCsDivision()
		{
			Calculator calc = new Calculator();
			calc.Number1 = 10;
			calc.Number2 = 10;
			double answer = calc.Divide();
			//Ensure that 10/10=1
			Assert.AreEqual(answer, 1d);
		}

	}
}
