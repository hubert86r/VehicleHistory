using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleHistory.DataAccessLayer.Models;

namespace VehicleHistory.UserInterface.Forms.Cars
{
     class CarEventArgs :EventArgs
    {
        public CarModel Car {  get; set; }

        public CarEventArgs(CarModel car)
        {
            this.Car = car;
        }
    }
}
