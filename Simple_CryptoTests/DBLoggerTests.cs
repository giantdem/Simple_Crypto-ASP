using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Crypto;
using System;

namespace Simple_Crypto.Tests
{
    [TestClass()]
    public class DBLoggerTests
    {
        //класс тестов ведения лога в БД

        [TestMethod()]
        public void LogInputTest()
        {
            //тест лога входных сообщений

            Entities e = new Entities();
            string input = "ggg";
            int exp_output = -1;
            int output = DBLogger.LogInput(input, ref e);

            CleanDBTests(e, output);

            Assert.AreNotEqual(exp_output, output);
        }
        public void CleanDBTests(Entities e, int output)
        {
            //очистка результатов работы с БД

            InputLog logTest = e.InputLog.Find(output);
            if (logTest == null) return;

            Console.WriteLine(logTest.id + " | " + logTest.message + " | " + logTest.time);

            //удаление записи лога после тестирования
            e.InputLog.Remove(logTest);

            e.SaveChanges();
        }
    }
}