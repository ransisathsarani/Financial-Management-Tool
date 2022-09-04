using FinancialManagementTool.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthenticateUser(object sender, EventArgs e)
        {
            String username = this.txtUserName.Text;
            String password = this.txtPassword.Text;

            //validations
            if(username == null || username == String.Empty)
            {
                MessageBox.Show("Username field is required", "Hey", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            
            UserProfileModel userProfileModel = new UserProfileModel();
            Boolean result = userProfileModel.LoginUser(username, password);
            if (result == true)
            {
                ExpenseIncomeAddView expenseIncomeAddView = new ExpenseIncomeAddView();
                expenseIncomeAddView.UserName = username;
                expenseIncomeAddView.Show();
                this.Hide();
            }
        }
    }
}
