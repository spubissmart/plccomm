using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ProductsApp.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class plcData
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("len")]
        public int len { get; set; }

        static void Main(string[] args)
        {

        }




    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

}