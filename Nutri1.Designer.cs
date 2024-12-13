namespace WindowsFormsApplication3
{
    partial class Nutri1
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dietChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suggestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourMealsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dietChartToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.suggestionsToolStripMenuItem,
            this.yourMealsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 104);
            // 
            // dietChartToolStripMenuItem
            // 
            this.dietChartToolStripMenuItem.Image = global::WindowsFormsApplication3.Properties.Resources.dietchart;
            this.dietChartToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dietChartToolStripMenuItem.Name = "dietChartToolStripMenuItem";
            this.dietChartToolStripMenuItem.Size = new System.Drawing.Size(188, 104);
            this.dietChartToolStripMenuItem.Text = "Diet Chart";
            this.dietChartToolStripMenuItem.Click += new System.EventHandler(this.dietChartToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::WindowsFormsApplication3.Properties.Resources.aboutus;
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(180, 104);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // suggestionsToolStripMenuItem
            // 
            this.suggestionsToolStripMenuItem.Image = global::WindowsFormsApplication3.Properties.Resources.suggestions;
            this.suggestionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suggestionsToolStripMenuItem.Name = "suggestionsToolStripMenuItem";
            this.suggestionsToolStripMenuItem.Size = new System.Drawing.Size(201, 104);
            this.suggestionsToolStripMenuItem.Text = "Suggestions";
            this.suggestionsToolStripMenuItem.Click += new System.EventHandler(this.suggestionsToolStripMenuItem_Click);
            // 
            // yourMealsToolStripMenuItem
            // 
            this.yourMealsToolStripMenuItem.Image = global::WindowsFormsApplication3.Properties.Resources.meal;
            this.yourMealsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yourMealsToolStripMenuItem.Name = "yourMealsToolStripMenuItem";
            this.yourMealsToolStripMenuItem.Size = new System.Drawing.Size(193, 104);
            this.yourMealsToolStripMenuItem.Text = "Your Meals";
            this.yourMealsToolStripMenuItem.Click += new System.EventHandler(this.yourMealsToolStripMenuItem_Click);
            // 
            // Nutri1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Nutri1";
            this.Text = "Nutri1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nutri1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dietChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suggestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourMealsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}