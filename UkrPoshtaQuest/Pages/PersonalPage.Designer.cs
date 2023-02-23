
namespace UkrPoshtaQuest.Pages
{
    partial class PersonalPage
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
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchItBtn = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.EmployeeDataGridView.Size = new System.Drawing.Size(1134, 137);
            this.EmployeeDataGridView.TabIndex = 0;
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Location = new System.Drawing.Point(901, 74);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(202, 55);
            this.AddEmployeeBtn.TabIndex = 1;
            this.AddEmployeeBtn.Text = "Додати працівника";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.HireDateDateTimePicker);
            this.panel1.Controls.Add(this.SearchItBtn);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.PositionTextBox);
            this.panel1.Controls.Add(this.DepartmentTextBox);
            this.panel1.Controls.Add(this.FullNameTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddEmployeeBtn);
            this.panel1.Controls.Add(this.EmployeeDataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 469);
            this.panel1.TabIndex = 3;
            // 
            // HireDateDateTimePicker
            // 
            this.HireDateDateTimePicker.Location = new System.Drawing.Point(611, 156);
            this.HireDateDateTimePicker.Name = "HireDateDateTimePicker";
            this.HireDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.HireDateDateTimePicker.TabIndex = 18;
            // 
            // SearchItBtn
            // 
            this.SearchItBtn.Location = new System.Drawing.Point(21, 235);
            this.SearchItBtn.Name = "SearchItBtn";
            this.SearchItBtn.Size = new System.Drawing.Size(784, 55);
            this.SearchItBtn.TabIndex = 16;
            this.SearchItBtn.Text = "Здійснити пошук";
            this.SearchItBtn.UseVisualStyleBackColor = true;
            this.SearchItBtn.Click += new System.EventHandler(this.SearchItBtn_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(611, 85);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(194, 22);
            this.PhoneTextBox.TabIndex = 13;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(611, 29);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(194, 22);
            this.AddressTextBox.TabIndex = 12;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(91, 151);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(194, 22);
            this.PositionTextBox.TabIndex = 11;
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(91, 90);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(194, 22);
            this.DepartmentTextBox.TabIndex = 10;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(91, 24);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(194, 22);
            this.FullNameTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата взяття на роботу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ПІБ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
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
            // PersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PersonalPage";
            this.Size = new System.Drawing.Size(1158, 488);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchItBtn;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HireDateDateTimePicker;
    }
}
