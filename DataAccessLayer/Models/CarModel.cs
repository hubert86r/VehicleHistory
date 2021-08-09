using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleHistory.DataAccessLayer.Models.Dictionaries;

namespace VehicleHistory.DataAccessLayer.Models
{
    public class CarModel :EntityModel
    {
        public string Name { get; set; }
        public BrandModel Brand { get; set; }
        public string Model { get; set; }
        public string Generation { get; set; }
        public DateTime ProductionDate { get; set; }
        public FuelTypeModel FuelType { get; set; }
        public string LicensePlate { get; set; }
        public string PaintCode { get; set; }
        public string EngineCode { get; set; }

    }
}
