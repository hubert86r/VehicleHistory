using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHistory.DataAccessLayer.Models.Dictionaries
{
    public class FuelTypeModel :EntityModel
    {
        public string Value { get; set; }

        public FuelTypeModel(string value)
        {
            Value = value;
        }
    }
}
