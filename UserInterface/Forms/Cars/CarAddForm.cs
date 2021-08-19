using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHistory.DataAccessLayer.Models.Dictionaries;
using VehicleHistory.UserInterface.Forms.Template;

namespace VehicleHistory.UserInterface.Forms.Cars
{
    public partial class CarAddForm : TemplateAddEditForm
    {
        public CarAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidDataControls();
        }

        private void ValidDataControls()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                epName.SetError(txtName, "Pole Nazwa jest wymagane");
            }
            else
            {
                epName.Clear();
            }
        }

        private void InitializeData()
        {
            IList<BrandModel> brands = new List<BrandModel>()
            {
                new BrandModel("Volgswagen"),
                new BrandModel("Opel"),
                new BrandModel("Fiat"),
                new BrandModel(string.Empty)
            };
            bsBrand.DataSource = brands;
            cbBrand.Text = string.Empty;

            IList<FuelTypeModel> fuelsType = new List<FuelTypeModel>()
            {
                new FuelTypeModel("Benzyna"),
                new FuelTypeModel("Benzyna+Gaz"),
                new FuelTypeModel("Dizel"),
                new FuelTypeModel(string.Empty)
            };
            bsFuelType.DataSource = fuelsType;
            cbFuelType.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        protected override void Save()
        {
            if (ValidateForm())
            {

            }
            Close();
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string nameErrorMessage = epName.GetError(txtName);
            if (!string.IsNullOrEmpty(nameErrorMessage))
            {
                sbErrorMessage.Append(nameErrorMessage);
            }
            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie auta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
            string licensePlateWarningMessage = epLicensePlate.GetError(txtLicensePlate);
            if (!string.IsNullOrEmpty(licensePlateWarningMessage))
            {
                DialogResult answer =
                    MessageBox.Show(
                        licensePlateWarningMessage + Environment.NewLine + "Czy na pewno chcesz kontynuawać",
                        "Dodawanie pojazdu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano!");
            Close();
        }

        private void dtpProductionDate_ValueChanged(object sender, EventArgs e)
        {
            dtpProductionDate.Format = DateTimePickerFormat.Short;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidDataControls();
        }

        private void txtLicensePlate_Validated(object sender, EventArgs e)
        {
            if (txtLicensePlate.TextLength == 7)
            {
                epLicensePlate.Clear();
            }
            else
            {
                epLicensePlate.SetError(txtLicensePlate, "Numer rejestracyjny powinien składać się z 7 znaków");
            }
        }
    }
}
