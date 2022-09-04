using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementTool
{
    public partial class IncomeAddView : Form
    {
        public IncomeAddView()
        {
            InitializeComponent();
        }

        private void MoveToPreviousPage(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Hide();
        }

        private void CurrentDateLoad(object sender, EventArgs e)
        {
            this.labelCurrentDate.Text = DateTime.Now.ToString("dddd , dd MMM");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
