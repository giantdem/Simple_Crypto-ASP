using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Crypto
{
    public static class Encryptor
    {
        public static string Encrypt(string input, ref Entities e)
        {
            string output = "";
            foreach (char x in input)
            {
                string newSymbol = e.CryptoChars.Find(x.ToString())?.newSymbol;
                if (newSymbol != null)
                {
                    if (char.IsUpper(x)) newSymbol = newSymbol.ToUpper();
                    output += newSymbol;
                }
                else output += x;
            }

            return output;
        }
    }
}