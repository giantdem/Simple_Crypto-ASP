using System;

namespace Simple_Crypto
{
    public static class DBLogger
    {
        //класс ведения лога в БД

        public static int LogInput(string input, ref Entities e)
        {
            //функция лога входных сообщений

            //формирование записи
            InputLog log = new InputLog { message = input, time = DateTime.Now };
            //добавление в таблицу в БД
            try
            {
                e.InputLog.Add(log);
                e.SaveChanges();
            }
            catch { return -1; }

            //индикация успеха записи лога
            return log.id;
        }
    }
}