
namespace UkrPoshtaQuest.Pages.Windows
{
    partial class EditCompanyInfoForm
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OldInfoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.NewInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(106, 298);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(100, 30);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Редагувати";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стара інформація";
            // 
            // OldInfoLabel
            // 
            this.OldInfoLabel.AutoSize = true;
            this.OldInfoLabel.Location = new System.Drawing.Point(241, 95);
            this.OldInfoLabel.Name = "OldInfoLabel";
            this.OldInfoLabel.Size = new System.Drawing.Size(88, 17);
            this.OldInfoLabel.TabIndex = 2;
            this.OldInfoLabel.Text = "OldInfoLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Нова інформація";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(511, 298);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 30);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Скасувати";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewInfoTextBox
            // 
            this.NewInfoTextBox.Location = new System.Drawing.Point(244, 165);
            this.NewInfoTextBox.MaxLength = 100;
            this.NewInfoTextBox.Name = "NewInfoTextBox";
            this.NewInfoTextBox.Size = new System.Drawing.Size(267, 22);
            this.NewInfoTextBox.TabIndex = 5;
            // 
            // EditCompanyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.NewInfoTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OldInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Name = "EditCompanyInfoForm";
            this.Text = "EditCompanyInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OldInfoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox NewInfoTextBox;
    }
}