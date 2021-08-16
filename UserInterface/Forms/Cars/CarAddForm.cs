using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleHistory.UserInterface.Forms.Template;

namespace VehicleHistory.UserInterface.Forms.Cars
{
    public partial class CarAddForm : TemplateAddEditForm
    {
        public CarAddForm()
        {
            InitializeComponent();
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
            MessageBox.Show("Zapisano!");
            Close();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano!");
            Close();
        }
    }
}
