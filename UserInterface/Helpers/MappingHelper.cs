using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleHistory.DataAccessLayer.Models;
using VehicleHistory.DataAccessLayer.ViewModel;

namespace VehicleHistory.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<CarViewModel> MapCarModelToCarViewModel(IList<CarModel> carsModel)
        {
            IList<CarViewModel> CarsViewModel = new List<CarViewModel>();

            foreach (CarModel carModel in carsModel)
            {
                CarViewModel CarViewModel = new CarViewModel();
                CarViewModel.Id = carModel.Id;
                CarViewModel.Name = carModel.Name;
                CarViewModel.Model = carModel.Model;
                CarViewModel.Brand = carModel.Brand.ToString();

                CarsViewModel.Add(CarViewModel);

            }

            return CarsViewModel;
        }

        public static CarViewModel MapCarModelToCarViewModel(CarModel carModel)
        {
            
            CarViewModel CarViewModel = new CarViewModel();
            CarViewModel.Id = carModel.Id;
            CarViewModel.Name = carModel.Name;
            CarViewModel.Model = carModel.Model;
            CarViewModel.Brand = carModel.Brand.ToString();

            return CarViewModel;
        }
    }
}
