using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsApplication
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void saveAndExitBtn_Click(object sender, EventArgs e)
        {
            saveNewCustomerInfo();
            this.Dispose();
            myReturnForm.Show();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            myReturnForm.Show();
        }
    }
}
