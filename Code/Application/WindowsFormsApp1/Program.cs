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
        //Account.createAccount("dasingleton", "David", "Singleton", "abc123");

        //Account.updateBilling("dasingleton", "1234567898765432", "456");

        //Account.updatePassword("dasingleton", "123xyz");

        //Account.printAccount("dasingleton");

        Manage.addCar("0ag2489","BMW","PHL","230","4","true","M5");

        Car.getCars("All Locations","All Models",2,400);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new WindowsFormsApp1.Home());
    }
}