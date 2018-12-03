using System;
using System.Collections.Generic;

class Car
{
    private static DataBase database = Program.database;

    public static List<String> fetchCar(String carId)
    {
        var data = database.readData("cars!A2:F");
        if (data != null)
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
        return null;
    }

    public static List<List<String>> getCars(String loc, String mod, int seating, int maxPrice)
    {
        List<List<String>> cars = new List<List<String>> { };
        foreach (var row in database.readData("cars!A2:G"))
        {
            if (loc.Equals("All Locations") || row[2].Equals(loc))
            {
                if (mod.Equals("All Models") || row[1].Equals(mod))
                {
                    if (int.Parse(row[3].ToString()) <= maxPrice)
                    {
                        if (int.Parse(row[4].ToString()) >= seating)
                        {
                            if (row[5].Equals("TRUE"))
                            {
                                List<String> info = new List<String> { row[0].ToString(), row[1].ToString(), row[2].ToString(),
                                    row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString()
                                };
                                cars.Add(info);
                            }
                        }
                    }
                }
            }
        }
        return cars;
    }

    public static List<String> getModels()
    {
        List<String> models = new List<String> { "All Models" };
        foreach (var row in database.readData("cars!A2:G"))
        {
            if (models.Exists(s => s.Contains(row[1].ToString()))==false)
            {
                models.Add(row[1].ToString());
            }
        }
        return models;
    }

    public static void addCar(String carId, String model, String loc, String price, String seating, String avail, String name)
    {
        if (Car.fetchCar(carId) == null)
        {
            database.writeData("cars!A2", new List<object>() { carId, model, loc, price, seating, avail, name });
        }
    }

    public static void removeCar(String carId)
    {
        var data = Account.fetchAccount(carId);
        if (data != null)
        {
            String range = "cars!" + "A" + data[0] + ":G";
            database.deleteData(range);
        }
    }

}