namespace Simple_Crypto
{
    public static class Encryptor
    {
        //класс шифрования

        public static string Encrypt(string input, ref Entities e)
        {
            //функция простого шифрования строки

            string output = "";
            //замена символов на соответствующие из БД
            foreach (char x in input)
            {
                string newSymbol = e.CryptoChars.Find(x.ToString())?.newSymbol;
                if (newSymbol != null)
                {
                    //обработка регистра буквы
                    if (char.IsUpper(x)) newSymbol = newSymbol.ToUpper();
                    //добавление символа к конечной строке
                    output += newSymbol;
                }
                else output += x;
            }

            return output;
        }
    }
}