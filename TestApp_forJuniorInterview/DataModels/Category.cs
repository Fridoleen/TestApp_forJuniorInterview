using Newtonsoft.Json;

namespace TestApp_forJuniorInterview
{
    class Category
    {
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public int CategoryID { get; set; }

        public Category(string name, int catId)
        {
            Name = name;
            CategoryID = catId;
        }
    }
}
