using System;
using System.Windows.Forms;
using System.Collections.Generic;

class Program
{

    public static DataBase database = new DataBase();

    static void Main()
    {
        Account.createAccount("dasingleton", "David", "Singleton", "abc123");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new HomePage());
    }
}