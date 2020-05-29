namespace Simple_Crypto
{
    public static class Encryptor
    {
        //class: encryption

        public static string Encrypt(string input, ref Entities e)
        {
            //function: simple string encryption

            string output = "";
            //replacing symbols with other ones from DB
            foreach (char x in input)
            {
                string newSymbol = e.CryptoChars.Find(x.ToString())?.newSymbol;
                if (newSymbol != null)
                {
                    //letter case handling
                    if (char.IsUpper(x)) newSymbol = newSymbol.ToUpper();
                    
                    output += newSymbol;
                }
                else output += x;
            }

            return output;
        }
    }
}