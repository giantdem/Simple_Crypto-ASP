﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Simple_Crypto.Tests
{
    [TestClass()]
    public class DBLoggerTests
    {
        [TestMethod()]
        public void LogInputTest()
        {
            Entities e = new Entities();
            string input = "ggg";
            int exp_output = -1;
            int output = DBLogger.LogInput(input, ref e);

            InputLog logTest = e.InputLog.Find(output);
            Console.WriteLine(logTest.id + " | " + logTest.message + " | " + logTest.time);
            e.InputLog.Remove(logTest);
            e.SaveChanges();

            Assert.AreNotEqual(exp_output, output);
        }
    }
}