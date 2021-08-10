using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHistory.DataAccessLayer.Models.Dictionaries
{
    public class BrandModel : EntityModel
    {
        public string Value { get; set; }

        public BrandModel(string value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToUpper();
        }
    }
}
