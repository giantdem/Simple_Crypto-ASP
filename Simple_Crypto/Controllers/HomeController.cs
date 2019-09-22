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
            Entities e = new Entities();

            string response = Encryptor.Encrypt(input, ref e);
            DBLogger.LogInput(input, ref e);

            return response;
        }
    }
}