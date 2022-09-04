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
    public partial class RegisterView : Form
    {

        public String UserName { get; set; }
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterViewLoad(object sender, EventArgs e)
        {
            this.labelUserName.Text = this.UserName;
        }

        private void AddExpense(object sender, EventArgs e)
        {
            ExpenseIncomeAddView expenseAddView = new ExpenseIncomeAddView();
            expenseAddView.Show();
            this.Hide();

        }

        private void AddIncome(object sender, EventArgs e)
        {
            IncomeAddView incomeAddView = new IncomeAddView();
            incomeAddView.Show();
            this.Hide();
        }

    }
}
