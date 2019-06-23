using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models
{
    public class VehicleFeature
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }
      
        public Vehicle Vehicle { get; set; }

        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        
    }
}
