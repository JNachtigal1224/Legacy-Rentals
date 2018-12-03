using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System;


class Program
{

    public static DataBase database = new DataBase();
    public static List<String> localAccount;

    public static WindowsFormsApp1.Home home;

    static void Main()
    {

        Manage.addCar("0ag2489", "BMW", "PHL", "230", "5", "true", "M5");
        Manage.addCar("0af1442", "Mercedes-Benz", "PHL", "580", "5", "true", "C63");
        Manage.addCar("0bb2980", "BMW", "NYC", "1200", "2", "true", "i8");
        Manage.addCar("0xr9048", "Chevy", "TPA", "400", "8", "true", "Tahoe");
        Manage.addCar("0ty0067", "Audi", "PHL", "520", "5", "true", "A6");
        Manage.addCar("0uo9820", "Tesla", "PHL", "790", "5", "true", "Model S");
        Manage.addCar("0xu7264", "Tesla", "NYC", "310", "5", "true", "Model 3");

        Car.getCars("All Locations", "All Models", 2, 400);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        home = new WindowsFormsApp1.Home();
        home.manageShow(false);
        Application.Run(home);
    }
}