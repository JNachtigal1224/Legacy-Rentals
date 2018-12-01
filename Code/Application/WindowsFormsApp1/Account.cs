using System;
using System.Collections.Generic;

class Account
{
    private static DataBase database = Program.database;

    public static List<String> fetchAccount(String username)
    {
        var data = database.readData("users!A2:F");
        if (data != null && data.Count > 2)
        {
            int rowNumber = 2;
            foreach (var row in data)
            {
                if (row[0].Equals(username))
                {
                    if (row.Count < 5)
                    {
                        return new List<String> { rowNumber.ToString(), row[0].ToString(), row[1].ToString(), row[2].ToString() };
                    }
                    else
                    {
                        return new List<String> { rowNumber.ToString(), row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString(), row[5].ToString() };
                    }
                }
                rowNumber++;
            }
        }
        return null;
    }

    public static void printAccount(String username)
    {
        var account = Account.fetchAccount("dasingleton");
        if (account != null)
        {
            Console.WriteLine("username: " + account[1]);
            Console.WriteLine("first name: " + account[2]);
            Console.WriteLine("last name: " + account[3]);
            Console.Read();
        }
    }

    public static void createAccount(String username, String firstName, String lastName, String password)
    {
        if (Account.fetchAccount(username) == null)
        {
            database.writeData("users!A2", new List<object>() { username, firstName, lastName, password });
        }
    }

    public static void updateBilling(String username, String cardNumber, String securityCode)
    {
        var data = Account.fetchAccount(username);
        if (data != null)
        {
            String range = "users!" + "E" + data[0] + ":F";
            database.updateData(range, new List<object>() { cardNumber, securityCode });
        }
    }

    public static void updatePassword(String username, String password)
    {
        var data = Account.fetchAccount(username);
        if (data != null)
        {
            String range = "users!" + "D" + data[0];
            database.updateData(range, new List<object>() { password });
        }
    }
}