
namespace UkrPoshtaQuest.Pages.Windows
{
    partial class FormWithEmployeesFilter
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
            this.FilterDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterDataGridView
            // 
            this.FilterDataGridView.AllowUserToAddRows = false;
            this.FilterDataGridView.AllowUserToDeleteRows = false;
            this.FilterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterDataGridView.Location = new System.Drawing.Point(12, 191);
            this.FilterDataGridView.Name = "FilterDataGridView";
            this.FilterDataGridView.ReadOnly = true;
            this.FilterDataGridView.RowHeadersWidth = 51;
            this.FilterDataGridView.RowTemplate.Height = 24;
            this.FilterDataGridView.Size = new System.Drawing.Size(658, 150);
            this.FilterDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПІБ";
            // 
            // FormWithEmployeesFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterDataGridView);
            this.Name = "FormWithEmployeesFilter";
            this.Text = "FormWithEmployeesFilter";
            ((System.ComponentModel.ISupportInitialize)(this.FilterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterDataGridView;
        private System.Windows.Forms.Label label1;
    }
}