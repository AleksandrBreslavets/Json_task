using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Json_task
{
    class Book
    {
        //[JsonIgnore]
        public int PublishingHouseId { get; set; }

        //[JsonPropertyName("Name")]
        public string Title { get; set; }

        public PublishingHouse PublishingHouse { get; set; }

        public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
        {
            Title = title;
            PublishingHouse = publishingHouse;
            PublishingHouseId = publishingHouseId;
        }
    }
}
