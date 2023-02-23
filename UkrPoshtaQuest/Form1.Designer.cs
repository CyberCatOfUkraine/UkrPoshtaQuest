
namespace UkrPoshtaQuest
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalaryReportingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainPageMenuItem,
            this.PersonalMenuItem,
            this.SalaryReportingMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainPageMenuItem
            // 
            this.MainPageMenuItem.Name = "MainPageMenuItem";
            this.MainPageMenuItem.Size = new System.Drawing.Size(144, 24);
            this.MainPageMenuItem.Text = "Головна сторінка";
            this.MainPageMenuItem.Click += new System.EventHandler(this.MainPageMenuItem_Click);
            // 
            // PersonalMenuItem
            // 
            this.PersonalMenuItem.Name = "PersonalMenuItem";
            this.PersonalMenuItem.Size = new System.Drawing.Size(92, 24);
            this.PersonalMenuItem.Text = "Персонал";
            this.PersonalMenuItem.Click += new System.EventHandler(this.PersonalMenuItem_Click);
            // 
            // SalaryReportingMenuItem
            // 
            this.SalaryReportingMenuItem.Name = "SalaryReportingMenuItem";
            this.SalaryReportingMenuItem.Size = new System.Drawing.Size(159, 24);
            this.SalaryReportingMenuItem.Text = "Зарплатна звітність";
            this.SalaryReportingMenuItem.Click += new System.EventHandler(this.SalaryReportingMenuItem_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Location = new System.Drawing.Point(12, 53);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1158, 488);
            this.ContainerPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonalMenuItem;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.ToolStripMenuItem SalaryReportingMenuItem;
    }
}

