using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleHistory.UserInterface.Forms.Template
{
    public partial class TemplateAddEditForm : TemplateForm
    {
        public TemplateAddEditForm()
        {
            InitializeComponent();
        }

        private void TemplateAddEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.Z)
            {
                Save();
            }
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                Cancel();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        protected virtual void Save() { }
        protected virtual void Cancel() { }
    }
}
