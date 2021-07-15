using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestApp_forJuniorInterview
{
    static class DataProcessor
    {
        public static void PostData(DataModel data)
        {
            var sortedData = from prod in data.Products
                             join cat in data.Categories on prod.CategoryID equals cat.CategoryID
                             select new { Prod = prod.Name, Cat = cat.Name };
            
            Console.WriteLine("Product \t \t \t \t Category");
            foreach (var item in sortedData)
            {
                if (item.Prod.Length < 7) Console.WriteLine($"{item.Prod} \t \t \t \t \t {item.Cat}");
                else if (item.Prod.Length < 17) Console.WriteLine($"{item.Prod} \t \t \t \t {item.Cat}");
                else Console.WriteLine($"{item.Prod} \t \t \t {item.Cat}");
            }
        }

        public static async Task<DataModel> GetData()
        {
            Console.WriteLine("eceiving data...");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(" https://tester.consimple.pro/"))
            {
                if (response.IsSuccessStatusCode)
                {
                    DataModel result = await response.Content.ReadAsAsync<DataModel>();
                    return result;
                }
                else
                {
                    throw new Exception("Couldn't download data");
                }
            }

        }
    }
}
