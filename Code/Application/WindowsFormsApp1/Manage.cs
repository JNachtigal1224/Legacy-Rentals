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

    public static void addRequest(String requestId, String carId, String username)
    {
        database.writeData("request!A2", new List<object>() { requestId, carId, username });
    }

    public static List<String> fetchRequest(String requestId)
    {
        var data = database.readData("request!A2:C");
        if (data != null)
        {
            int rowNumber = 2;
            foreach (var row in data)
            {
                if (row[0].Equals(requestId))
                {
                    return new List<String> { rowNumber.ToString(), row[0].ToString(), row[1].ToString(), row[2].ToString() };
                }
                rowNumber++;
            }
        }
        return null;
    }

    public static void removeRequest(String requestId)
    {
        var data = Manage.fetchRequest(requestId);
        if (data != null)
        {
            String range = "request!" + "A" + data[0] + ":C";
            database.deleteData(range);
        }
    }

}