using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHistory.DataAccessLayer.ViewModel
{
    public class CarViewModel
    {
        public int Id { get; set; }

        private string name;
        public string Name {
            get { return name.ToUpper(); }
            set { name = value; }
        }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
