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
                try { output += e.CryptoChars.Find(x.ToString()).newSymbol; }
                catch { output += x; }
            }

            return output;
        }
    }
}