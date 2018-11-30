using System;
using System.Collections.Generic;

class Manage
{
    private static DataBase database = Program.database;

    public static void addCar(String carId)
    {
        Car.addCar(carId);
    }
}
