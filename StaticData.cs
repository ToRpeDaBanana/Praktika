using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika
{
    static class StaticData
    {
        public static string Login = "login"; //передача имени пользователя чата из логина аккаунта

        public static Form7 frm7 = new Form7(); //объявление формы чата

        public static void frm7Hide() //скрытие формы чата
        {
            frm7.Hide();
        }

        public static void frm7Show() //вызов формы чата
        {
            frm7.Show();
        }
    }
}
