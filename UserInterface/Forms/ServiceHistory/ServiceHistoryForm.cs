using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleHistory.UserInterface.Forms.ServiceHistory
{
    public partial class ServiceHistoryForm : Form
    {
        private static ServiceHistoryForm _instance = null;

        public static ServiceHistoryForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceHistoryForm();
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
        public ServiceHistoryForm()
        {
            InitializeComponent();
        }

        private void ServiceHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
