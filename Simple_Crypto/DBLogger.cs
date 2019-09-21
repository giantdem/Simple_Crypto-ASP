using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Crypto
{
    public static class DBLogger
    {
        public static int LogInput(string input, ref Entities e)
        {
            InputLog log = new InputLog { message = input, time = DateTime.Now };
            try
            {
                e.InputLog.Add(log);
                e.SaveChanges();
            }
            catch { return -1; }

            return log.id;
        }
    }
}