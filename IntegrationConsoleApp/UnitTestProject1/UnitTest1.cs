using System;
using IntegrationConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var calc = new Library();

			var result = calc.GetInt("42");

			Assert.AreEqual(42, result);
		}
	}
}
