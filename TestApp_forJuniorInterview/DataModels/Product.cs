using Newtonsoft.Json;

namespace TestApp_forJuniorInterview
{
    class Product
    {
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public int ProductID { get; set; }

        [JsonProperty(PropertyName = "CategoryId")]
        public int CategoryID { get; set; }

        public Product(string name, int prodId, int catId)
        {
            Name = name;
            ProductID = prodId;
            CategoryID = catId;
        }
    }
}
