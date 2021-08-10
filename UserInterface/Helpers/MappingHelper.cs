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
        public static IList<CarViewModel> MapCarModelToCarViewModel(IList<CarModel> carModel)
        {
            IList<CarViewModel> CarsViewModel = new List<CarViewModel>();

            foreach (CarModel CarModel in carModel)
            {
                CarViewModel CarViewModel = new CarViewModel();
                CarViewModel.Id = CarModel.Id;
                CarViewModel.Name = CarModel.Name;
                CarViewModel.Model = CarModel.Model;
                CarViewModel.Brand = CarModel.Brand.ToString();

                CarsViewModel.Add(CarViewModel);

            }

            return CarsViewModel;
        }
    }
}
