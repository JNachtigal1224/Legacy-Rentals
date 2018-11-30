using System;
using System.Windows.Forms;
using System.Collections.Generic;

class Program
{

    public static DataBase database = new DataBase();

    static void Main()
    {
        //IList<IList<Object>> values = database.readData("users!A2:A");

        //database.deleteData("users!A2");

        Account.createAccount("dasingleton", "David", "Singleton", "abc123");

        Account.updateBilling("dasingleton", "1234567898765432", "456");

        Account.updatePassword("dasingleton", "123xyz");

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
        Application.Run(new WindowsFormsApp1.Home());

    }
}