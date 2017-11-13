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
    public partial class CustomerAppForm : Form
    {
        public CustomerAppForm()
        {
            InitializeComponent();
        }

        private void listAllCustomersBtn_Click(object sender, EventArgs e)
        {
            ListAllCustomersForm myListAllCustomersForm = new ListAllCustomersForm(this);
            myListAllCustomersForm.Show();
            this.Hide();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomerForm myAddCustomerForm = new AddCustomerForm(this);
            myAddCustomerForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
