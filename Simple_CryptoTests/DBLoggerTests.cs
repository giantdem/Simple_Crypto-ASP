using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Crypto;
using System;

namespace Simple_Crypto.Tests
{
    [TestClass()]
    public class DBLoggerTests
    {
        //class: DB logging tests

        [TestMethod()]
        public void LogInputTest()
        {
            //test: input message logging

            Entities e = new Entities();
            string input = "ggg";
            int exp_output = -1;
            int output = DBLogger.LogInput(input, ref e);

            CleanDBTests(e, output);

            Assert.AreNotEqual(exp_output, output);
        }
        public void CleanDBTests(Entities e, int output)
        {
            //cleaning test job results in DB

            InputLog logTest = e.InputLog.Find(output);
            if (logTest == null) return;

            Console.WriteLine(logTest.id + " | " + logTest.message + " | " + logTest.time);

            //cleaning logs
            e.InputLog.Remove(logTest);

            e.SaveChanges();
        }
    }
}