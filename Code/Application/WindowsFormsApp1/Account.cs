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
        int rowNumber = 2;
        foreach (var row in database.readData("users!A2:F"))
        {
            if (row[0].Equals(username))
            {
                return new List<String> {rowNumber.ToString(),row[0].ToString(),row[1].ToString(),row[2].ToString(),row[3].ToString()};
            }
            rowNumber++;
        }
        return null;
    }

    public static void createAccount(String username, String firstName, String lastName, String password)
    {
        database.writeData("users!A2",new List<object>() {username, firstName, lastName, password});
    }

    public static void updateBilling(String username, String cardNumber, String securityCode)
    {
        String range = "users!" + "E" + Account.fetchAccount(username)[0] + ":F";
        database.updateData(range, new List<object>() {cardNumber,securityCode});
    }

}