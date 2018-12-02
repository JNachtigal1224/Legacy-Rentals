using System;
using System.Collections.Generic;

class Manage
{
    private static DataBase database = Program.database;

    public static void addCar(String carId, String model, String loc, String price, String seating, String avail, String name)
    {
        Car.addCar(carId, model, loc, price, seating, avail, name);
    }

    public static void removeCar(String carId)
    {
        Car.removeCar(carId);
    }

}
