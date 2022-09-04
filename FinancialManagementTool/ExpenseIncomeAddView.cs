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
    public partial class ExpenseIncomeAddView : Form
    {
        public String UserName { get; set; }

        DataTable table = new DataTable("table");

        int index;

        public ExpenseIncomeAddView()
        {
            InitializeComponent();
        }

        private void MoveToPreviousPage(object sender, EventArgs e)
        {
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Hide();
        }

        //Add expense details
        private void AddExpenseDetails(object sender, EventArgs e)
        {
            table.Rows.Add(
                typeComboBox.Text, 
                txtExpAmount.Text, 
                categoryComboBox.Text, 
                dateTimePicker1.Value,
                txtExpNote.Text
                );


            if (typeComboBox != null && txtExpAmount != null && categoryComboBox != null && dateTimePicker1 != null || txtExpNote != null)
            {
                MessageBox.Show("Success", "Hey", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
        }

        //Load data
        private void LoadExpenseDataList(object sender, EventArgs e)
        {

            this.labelUserName.Text = this.UserName;
            this.labelCurrentDate.Text = DateTime.Now.ToString("dddd , dd MMM");
  
            table.Columns.Add("Type", Type.GetType("System.String"));
            table.Columns.Add("Amount", Type.GetType("System.Double"));
            table.Columns.Add("Category", Type.GetType("System.String"));
            table.Columns.Add("Date", Type.GetType("System.DateTime"));
            table.Columns.Add("Note", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

            this.labelTotalExpense.Text = dataGridView1.Rows.Count.ToString();
            this.labelTotalIncome.Text = (from DataGridViewRow row in dataGridView1.Rows
                                         where row.Cells[1].FormattedValue.ToString()!= String.Empty
                                         select Convert.ToInt32(row.Cells[1].FormattedValue)).Sum().ToString();


        }

        private void AddNewExpenseRecord(object sender, EventArgs e)
        {
            typeComboBox.Text = String.Empty;
            txtExpAmount.Text = String.Empty;
            categoryComboBox.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            txtExpNote.Text = String.Empty;

        }

        private void ExpenseDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            typeComboBox.Text = row.Cells[0].Value.ToString();
            txtExpAmount.Text = row.Cells[1].Value.ToString();
            categoryComboBox.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            txtExpNote.Text = row.Cells[4].Value.ToString();

        }

        //Edit expense records
        private void EditExpenseRecord(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = typeComboBox.Text;
            newdata.Cells[1].Value = txtExpAmount.Text;
            newdata.Cells[2].Value = categoryComboBox.Text;
            newdata.Cells[3].Value = dateTimePicker1.Text;
            newdata.Cells[4].Value = txtExpNote.Text;
        }

        //Delete expense records
        private void DeleteExpenseRecord(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void LogoutClick(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        //Load data filter by date range
        private void LoadDataByDateRange(object sender, EventArgs e)
        {
            DataGridViewRow row;
            if (DateTime.Compare(dateTimePickerTo.Value.Date, dateTimePickerFrom.Value.Date) != 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    row = dataGridView1.Rows[i];
                    DateTime rowDate = (DateTime)row.Cells[3].Value;
                    if (rowDate.Date >= dateTimePickerFrom.Value.Date && rowDate.Date <= dateTimePickerTo.Value.Date)
                    {
                        if (row.Cells[0].Value.ToString() == "Income")
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a date week after the 'to date'", "Invalid date difference", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
