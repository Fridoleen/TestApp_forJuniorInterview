using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TestApp_forJuniorInterview
{
    class DataModel
    {
        [JsonProperty(PropertyName = "Products")]
        public Product[] Products { get; set; }

        [JsonProperty(PropertyName = "Categories")]
        public Category[] Categories { get; set; }

        public DataModel()
        { }

        public DataModel(ICollection<Product> prod, ICollection<Category> cat)
        {
            Products = prod.ToArray();
            Categories = cat.ToArray();
        }
    }
}
