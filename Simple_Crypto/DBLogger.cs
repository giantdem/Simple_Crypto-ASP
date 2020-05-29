using System;

namespace Simple_Crypto
{
    public static class DBLogger
    {
        //class: DB logging

        public static int LogInput(string input, ref Entities e)
        {
            //function: input messages logging

            //row making
            InputLog log = new InputLog { message = input, time = DateTime.Now };
            //row pushing
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