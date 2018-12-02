using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System;

class Program
{

    public static DataBase database = new DataBase();
    public static List<String> localAccount;

    static void Main()
    {
        Account.createAccount("dasingleton", "David", "Singleton", "abc123");

        Account.updateBilling("dasingleton", "1234567898765432", "456");

        Account.updatePassword("dasingleton", "123xyz");

        Account.printAccount("dasingleton");

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new WindowsFormsApp1.Home());
    }
}