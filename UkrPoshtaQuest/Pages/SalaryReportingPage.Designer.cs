
namespace UkrPoshtaQuest.Pages
{
    partial class SalaryReportingPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxSalaryTextBox = new System.Windows.Forms.TextBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComputeBtn = new System.Windows.Forms.Button();
            this.MinSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MaxSalaryTextBox);
            this.panel1.Controls.Add(this.PositionComboBox);
            this.panel1.Controls.Add(this.DepartmentComboBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.HireDateDateTimePicker);
            this.panel1.Controls.Add(this.ComputeBtn);
            this.panel1.Controls.Add(this.MinSalaryTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmployeeDataGridView);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 469);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(792, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Від";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "До";
            // 
            // MaxSalaryTextBox
            // 
            this.MaxSalaryTextBox.Location = new System.Drawing.Point(882, 124);
            this.MaxSalaryTextBox.Name = "MaxSalaryTextBox";
            this.MaxSalaryTextBox.Size = new System.Drawing.Size(194, 22);
            this.MaxSalaryTextBox.TabIndex = 22;
            this.MaxSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxSalaryTextBox_KeyPress);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(91, 149);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(194, 24);
            this.PositionComboBox.TabIndex = 21;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(91, 26);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(194, 24);
            this.DepartmentComboBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 67);
            this.button1.TabIndex = 19;
            this.button1.Text = "Експортувати в TXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExportToTxt_Click);
            // 
            // HireDateDateTimePicker
            // 
            this.HireDateDateTimePicker.Location = new System.Drawing.Point(497, 94);
            this.HireDateDateTimePicker.Name = "HireDateDateTimePicker";
            this.HireDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.HireDateDateTimePicker.TabIndex = 18;
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Location = new System.Drawing.Point(21, 235);
            this.ComputeBtn.Name = "ComputeBtn";
            this.ComputeBtn.Size = new System.Drawing.Size(784, 55);
            this.ComputeBtn.TabIndex = 16;
            this.ComputeBtn.Text = "Здійснити обрахування";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.ComputeBtn_Click);
            // 
            // MinSalaryTextBox
            // 
            this.MinSalaryTextBox.Location = new System.Drawing.Point(882, 67);
            this.MinSalaryTextBox.Name = "MinSalaryTextBox";
            this.MinSalaryTextBox.Size = new System.Drawing.Size(194, 22);
            this.MinSalaryTextBox.TabIndex = 12;
            this.MinSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinSalaryTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Початкова дата найму";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Зарплата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Відділ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Посада";
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(3, 327);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 24;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(808, 137);
            this.EmployeeDataGridView.TabIndex = 0;
            // 
            // SalaryReportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SalaryReportingPage";
            this.Size = new System.Drawing.Size(1158, 488);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker HireDateDateTimePicker;
        private System.Windows.Forms.TextBox MinSalaryTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxSalaryTextBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.Button ComputeBtn;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
    }
}
