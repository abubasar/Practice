﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public bool IsRegistered { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<VehicleFeature> VehicleFeatures { get; set; }


    }
}
