using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    static class Program
    {

        static DataBase database = new DataBase();

        static void Main()
        {
            IList<IList<Object>> values = database.readData("users!A2:A");

            database.deleteData("users!A2");

            database.updateData("users!A2",new List<object>(){"911"});

            database.writeData("users!A2:A",new List<object>(){"984957","nancy_drew"});

            //if (values != null && values.Count > 0)
            //{
            //    Console.WriteLine("userId,username");
            //    foreach (var row in values)
            //    {
            //        Console.WriteLine("{0}, {1}", row[0], row[0]);
            //    }
            //}
            //Console.Read();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());



        }
    }
}