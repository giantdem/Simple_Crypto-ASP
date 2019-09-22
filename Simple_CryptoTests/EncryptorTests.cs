using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Crypto.Tests
{
    [TestClass()]
    public class EncryptorTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            Entities e = new Entities();
            string input = "абв2uUаВ";
            string exp_output = "тшь2uUтЬ";

            string output = Encryptor.Encrypt(input, ref e);

            Assert.AreEqual(exp_output, output);
        }
    }
}