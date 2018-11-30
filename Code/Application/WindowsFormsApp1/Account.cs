using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    private static DataBase database = Program.database;

    public static List<String> fetchAccount(String username)
    {
        foreach (var row in database.readData("users!A2:E"))
        {
            //Console.WriteLine("{0}, {1}", row[0], row[4]);
            if (row[1].Equals(username))
            {
                return new List<String> {row[0].ToString(),row[1].ToString(),row[2].ToString(),row[3].ToString()};
            }
        }
        Console.Read();
        return new List<String> { "", "", "", "" };
    }
}