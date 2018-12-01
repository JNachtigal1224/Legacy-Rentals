using System;
using System.Collections.Generic;

class Car
{
    private static DataBase database = Program.database;

    public static List<String> fetchCar(String carId)
    {
        int rowNumber = 2;
        foreach (var row in database.readData("cars!A2:F"))
        {
            if (row[0].Equals(carId))
            {
                return new List<String> { rowNumber.ToString(), row[0].ToString() };
            }
            rowNumber++;
        }
        return null;
    }

    public static void addCar(String carId)
    {
        if (Car.fetchCar(carId) == null)
        {
            database.writeData("cars!A2", new List<object>() { carId });
        }
    }

    public static void removeCar(String carId)
    {
        if (Car.fetchCar(carId) == null)
        {
            database.updateData("cars!A2", new List<object>() { carId });
        }
    }

}