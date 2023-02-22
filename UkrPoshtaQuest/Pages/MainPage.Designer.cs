
namespace UkrPoshtaQuest.Pages
{
    partial class MainPage
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
            this.CompanyDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCompanyInfoBtn = new System.Windows.Forms.Button();
            this.CompanyInfoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CompanyInfoTextBox);
            this.panel1.Controls.Add(this.AddCompanyInfoBtn);
            this.panel1.Controls.Add(this.CompanyDataGridView);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 500);
            this.panel1.TabIndex = 0;
            // 
            // CompanyDataGridView
            // 
            this.CompanyDataGridView.AllowUserToOrderColumns = true;
            this.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDataGridView.Location = new System.Drawing.Point(3, 88);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.RowHeadersWidth = 51;
            this.CompanyDataGridView.RowTemplate.Height = 24;
            this.CompanyDataGridView.Size = new System.Drawing.Size(762, 407);
            this.CompanyDataGridView.TabIndex = 1;
            this.CompanyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellContentClick);
            // 
            // AddCompanyInfoBtn
            // 
            this.AddCompanyInfoBtn.Location = new System.Drawing.Point(604, 39);
            this.AddCompanyInfoBtn.Name = "AddCompanyInfoBtn";
            this.AddCompanyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCompanyInfoBtn.TabIndex = 2;
            this.AddCompanyInfoBtn.Text = "Додати";
            this.AddCompanyInfoBtn.UseVisualStyleBackColor = true;
            this.AddCompanyInfoBtn.Click += new System.EventHandler(this.AddCompanyInfoBtn_Click);
            // 
            // CompanyInfoTextBox
            // 
            this.CompanyInfoTextBox.Location = new System.Drawing.Point(260, 39);
            this.CompanyInfoTextBox.MaxLength = 100;
            this.CompanyInfoTextBox.Name = "CompanyInfoTextBox";
            this.CompanyInfoTextBox.Size = new System.Drawing.Size(309, 22);
            this.CompanyInfoTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть інформацію про компанію";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(790, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CompanyDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyInfoTextBox;
        private System.Windows.Forms.Button AddCompanyInfoBtn;
    }
}
