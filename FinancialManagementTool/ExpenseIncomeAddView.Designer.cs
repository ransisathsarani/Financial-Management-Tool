namespace FinancialManagementTool
{
    partial class ExpenseIncomeAddView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.txtExpNote = new System.Windows.Forms.RichTextBox();
            this.txtExpAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExpenseAdd = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddNewExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTotalExpense = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDataByDateRange = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(21, 20);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(46, 16);
            this.labelCurrentDate.TabIndex = 1;
            this.labelCurrentDate.Text = "label1";
            // 
            // txtExpNote
            // 
            this.txtExpNote.Location = new System.Drawing.Point(86, 304);
            this.txtExpNote.Name = "txtExpNote";
            this.txtExpNote.Size = new System.Drawing.Size(206, 48);
            this.txtExpNote.TabIndex = 2;
            this.txtExpNote.Text = "";
            // 
            // txtExpAmount
            // 
            this.txtExpAmount.Location = new System.Drawing.Point(85, 188);
            this.txtExpAmount.Name = "txtExpAmount";
            this.txtExpAmount.Size = new System.Drawing.Size(206, 20);
            this.txtExpAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            // 
            // btnExpenseAdd
            // 
            this.btnExpenseAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnExpenseAdd.Location = new System.Drawing.Point(216, 371);
            this.btnExpenseAdd.Name = "btnExpenseAdd";
            this.btnExpenseAdd.Size = new System.Drawing.Size(75, 23);
            this.btnExpenseAdd.TabIndex = 13;
            this.btnExpenseAdd.Text = "Add";
            this.btnExpenseAdd.UseVisualStyleBackColor = false;
            this.btnExpenseAdd.Click += new System.EventHandler(this.AddExpenseDetails);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Food",
            "Health",
            "Transport",
            "Bills",
            "Clothes",
            "Education",
            "Entertainment",
            "Deposits",
            "Salary",
            "Savings",
            "Other"});
            this.categoryComboBox.Location = new System.Drawing.Point(85, 226);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(206, 21);
            this.categoryComboBox.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 246);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseDataGridViewCellClick);
            // 
            // btnAddNewExpense
            // 
            this.btnAddNewExpense.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNewExpense.Location = new System.Drawing.Point(85, 371);
            this.btnAddNewExpense.Name = "btnAddNewExpense";
            this.btnAddNewExpense.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewExpense.TabIndex = 17;
            this.btnAddNewExpense.Text = "Reset";
            this.btnAddNewExpense.UseVisualStyleBackColor = false;
            this.btnAddNewExpense.Click += new System.EventHandler(this.AddNewExpenseRecord);
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditExpense.Location = new System.Drawing.Point(811, 76);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(75, 23);
            this.btnEditExpense.TabIndex = 18;
            this.btnEditExpense.Text = "Edit";
            this.btnEditExpense.UseVisualStyleBackColor = false;
            this.btnEditExpense.Click += new System.EventHandler(this.EditExpenseRecord);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteExpense.Location = new System.Drawing.Point(897, 76);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteExpense.TabIndex = 19;
            this.btnDeleteExpense.Text = "Delete";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.DeleteExpenseRecord);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.typeComboBox.Location = new System.Drawing.Point(86, 158);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(205, 21);
            this.typeComboBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hi, ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(754, 20);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(46, 16);
            this.labelUserName.TabIndex = 23;
            this.labelUserName.Text = "label6";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Total Income";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTotalExpense
            // 
            this.txtTotalExpense.AutoSize = true;
            this.txtTotalExpense.Location = new System.Drawing.Point(443, 421);
            this.txtTotalExpense.Name = "txtTotalExpense";
            this.txtTotalExpense.Size = new System.Drawing.Size(75, 13);
            this.txtTotalExpense.TabIndex = 30;
            this.txtTotalExpense.Text = "Total Expense";
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Location = new System.Drawing.Point(322, 450);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(35, 13);
            this.labelTotalIncome.TabIndex = 31;
            this.labelTotalIncome.Text = "label8";
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Location = new System.Drawing.Point(464, 450);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(35, 13);
            this.labelTotalExpense.TabIndex = 32;
            this.labelTotalExpense.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Manage Income and Expenses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Add Income and Expense";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Silver;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(897, 20);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 35;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.LogoutClick);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(343, 123);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 36;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(600, 123);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 37;
            // 
            // btnLoadDataByDateRange
            // 
            this.btnLoadDataByDateRange.Location = new System.Drawing.Point(897, 123);
            this.btnLoadDataByDateRange.Name = "btnLoadDataByDateRange";
            this.btnLoadDataByDateRange.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDataByDateRange.TabIndex = 38;
            this.btnLoadDataByDateRange.Text = "Load";
            this.btnLoadDataByDateRange.UseVisualStyleBackColor = true;
            this.btnLoadDataByDateRange.Click += new System.EventHandler(this.LoadDataByDateRange);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "From:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "To:";
            // 
            // ExpenseIncomeAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLoadDataByDateRange);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTotalExpense);
            this.Controls.Add(this.labelTotalIncome);
            this.Controls.Add(this.txtTotalExpense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnEditExpense);
            this.Controls.Add(this.btnAddNewExpense);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.btnExpenseAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpAmount);
            this.Controls.Add(this.txtExpNote);
            this.Controls.Add(this.labelCurrentDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseIncomeAddView";
            this.Text = "Manage Income & Expenses";
            this.Load += new System.EventHandler(this.LoadExpenseDataList);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.RichTextBox txtExpNote;
        private System.Windows.Forms.TextBox txtExpAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExpenseAdd;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNewExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label txtTotalExpense;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button btnLoadDataByDateRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}