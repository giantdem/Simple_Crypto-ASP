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
            //функция координации задачи шифрования

            //сущности БД
            Entities e = new Entities();

            //шифрование
            string response = Encryptor.Encrypt(input, ref e);
            //лог исходного сообщения
            if (DBLogger.LogInput(input, ref e) == -1) Console.WriteLine("Ошибка лога");

            return response;
        }
    }
}