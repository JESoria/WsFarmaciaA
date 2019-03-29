using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaA.Models
{
    public class DistanceModel
    {
        private double dis;

        public DistanceModel(double dis)
        {
            this.dis = dis;
        }

        [JsonProperty(PropertyName = "distance")]
        public double distance  { get; set; }

    }
}