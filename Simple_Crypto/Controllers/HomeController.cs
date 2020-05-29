using System;
using System.Web.Mvc;

namespace Simple_Crypto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string EncryptMsg(string input)
        {
            //function: encryption task handling

            Entities e = new Entities();

            string response = Encryptor.Encrypt(input, ref e);
            //input message log
            if (DBLogger.LogInput(input, ref e) == -1) Console.WriteLine("Ошибка лога");

            return response;
        }
    }
}