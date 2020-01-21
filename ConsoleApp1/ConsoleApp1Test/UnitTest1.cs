using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGreetMethod()
        {


            var app = new ConsoleApp1.ConsoleApp1();

            var name = "Jose";

            var res = app.Greet(name);
            System.Diagnostics.Debug.Assert(res == $"{name} have a nice day!");

        }
    }
}
