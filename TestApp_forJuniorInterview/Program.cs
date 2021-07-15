using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp_forJuniorInterview
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiHelper.InitializeClient();

            var key = new ConsoleKeyInfo();

            while(key.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Press R to receive and post data on the screen, ESC to close window");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.R)
                {
                    DataModel data = await DataProcessor.GetData();
                    DataProcessor.PostData(data);
                }
                else Console.WriteLine("Unknown command");

                Console.WriteLine("\n");
            }
        }

        
    }
}
