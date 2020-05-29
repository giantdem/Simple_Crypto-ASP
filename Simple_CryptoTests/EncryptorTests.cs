using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Crypto;

namespace Simple_Crypto.Tests
{
    [TestClass()]
    public class EncryptorTests
    {
        //class: encryption tests

        [TestMethod()]
        public void EncryptTest()
        {
            //test: simple string encryption

            Entities e = new Entities();
            string input = "абв2uUаВ";
            string exp_output = "тшь2uUтЬ";

            string output = Encryptor.Encrypt(input, ref e);

            Assert.AreEqual(exp_output, output);
        }
    }
}