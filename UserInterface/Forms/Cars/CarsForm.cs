using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHistory.DataAccessLayer.Models;
using VehicleHistory.DataAccessLayer.Models.Dictionaries;
using VehicleHistory.DataAccessLayer.ViewModel;
using VehicleHistory.UserInterface.Helpers;

namespace VehicleHistory.UserInterface.Forms.Cars
{
    public partial class CarsForm : Form
    {
        private static CarsForm _instance = null;
        private static IList<CarViewModel> fakeCars;

        public static CarsForm Instance 
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new CarsForm();
                }
                return _instance;
            }
        }
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private CarsForm()
        {
            InitializeComponent();
            fakeCars = GetFakeCars();
            PrepareCarsData();
        }

        private void PrepareCarsData()
        {
            bsCars.DataSource = new BindingList<CarViewModel>(fakeCars);
            dgvCars.DataSource = bsCars;
        }

        private IList<CarViewModel> GetFakeCars()
        {
            IList<CarModel> fakeCarsModel = new List<CarModel>()
            {
                new CarModel()
                {
                    Id = 1,
                    Name = "Bertek",
                    Brand = new BrandModel("Volgswagen"),
                    Model = "Polo",
                    Generation = "R6",
                    ProductionDate = new DateTime(2014,1,1),
                    FuelType = new FuelTypeModel("Bęzyna"),
                    LicensePlate = "WR9799R",
                    PaintCode = "123456",
                    EngineCode = "654321"
                },
                new CarModel()
                {
                    Id = 2,
                    Name = "Stary Bertek",
                    Brand = new BrandModel("Opel"),
                    Model = "Astra",
                    Generation = "G",
                    ProductionDate = new DateTime(2000,1,1),
                    FuelType = new FuelTypeModel("Bęzyna+Gaz"),
                    LicensePlate = "WR55447",
                    PaintCode = "678967",
                    EngineCode = "123412"
                },
                new CarModel()
                {
                    Id = 3,
                    Name = "Stara astra",
                    Brand = new BrandModel("Opel"),
                    Model = "Astra",
                    Generation = "F",
                    ProductionDate = new DateTime(1995,1,1),
                    FuelType = new FuelTypeModel("Bęzyna"),
                    LicensePlate = "WR35789",
                    PaintCode = "345123",
                    EngineCode = "890765"
                }
            };
            return MappingHelper.MapCarModelToCarViewModel(fakeCarsModel);
        }   

        private void CarsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarAddForm frm = new CarAddForm();
            frm.ShowDialog();
        }
    }
}
