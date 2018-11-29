using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    class DataBase
    {

        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Legacy Rentals DataBase";

        static void Main()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1YPcGEQC6DMhw6WX2Q13gLFpgPBOgpozA-ywmeZyHONk";

            void writeData(String range, List<object> data)
            {
                var valueRange = new ValueRange();

                valueRange.Values = new List<IList<object>> { data };

                var appendRequest = service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
                appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                var appendReponse = appendRequest.Execute();
            }

            void readData(String range)
            {
                var valueRange = new ValueRange();

                var oblist = new List<object>() { "Hello!", "This", "was", "insertd", "via", "C#" };
                valueRange.Values = new List<IList<object>> { oblist };

                var getRequest = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var getReponse = getRequest.Execute();

                IList<IList<Object>> values = getReponse.Values;
                if (values != null && values.Count > 0)
                {
                    Console.WriteLine("userId,username");
                    foreach (var row in values)
                    {
                        Console.WriteLine("{0}, {1}", row[0], row[0]);
                    }
                }
                Console.Read();
            }

            //readData("users!A2:A");
            //writeData("users!A2:A", new List<object>() { "984957", "nancy_drew" });
        }

    }
}
