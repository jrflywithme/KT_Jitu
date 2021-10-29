using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blalogin.Data
{
    public class Route
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Routename { get; set; }
        public string Supervisorname { get; set; }
        public int Billdays { get; set; }
        public int Code { get; set; }
   

    }

    public class RoutesApiResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public List<Route> Routes { get; set; }
    }
}
