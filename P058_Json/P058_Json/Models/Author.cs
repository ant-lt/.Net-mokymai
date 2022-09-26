using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json.Models
{
    //POCO class
    public class Author
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("courses")]
        public string[] Courses { get; set; }

        [JsonProperty("since")]
        public DateTime Since { get; set; }

        [JsonProperty("happy")]
        public bool Happy { get; set; }

        [JsonProperty("issues")]
        public object? Issues { get; set; }

        [JsonProperty("car")]
        public Car Car { get; set; }

        [JsonProperty("authorRelationship")]
        public EAuthorRelationship AuthorRelationship { get; set; }

    }
}
