namespace WebApiF1.Models.ApiModels
{
    public class BookApiResult
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("pageCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PageCount { get; set; }

        [Newtonsoft.Json.JsonProperty("excerpt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Excerpt { get; set; }

        [Newtonsoft.Json.JsonProperty("publishDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset PublishDate { get; set; }
    }


    //public class Rootobject //copy -> Egit -> Paste Special -> Paste JSON as Classes
    //{
    //    public int id { get; set; }
    //    public string title { get; set; }
    //    public string description { get; set; }
    //    public int pageCount { get; set; }
    //    public string excerpt { get; set; }
    //    public DateTime publishDate { get; set; }
    //}

    
}
