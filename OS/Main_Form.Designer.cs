namespace OS
{
    partial class Main_Form
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
            this.processSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processSchedulingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fixedPartitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_view = new System.Windows.Forms.Panel();
            this.pageReplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processSchedulingToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processSchedulingToolStripMenuItem
            // 
            this.processSchedulingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processSchedulingToolStripMenuItem1,
            this.fixedPartitionToolStripMenuItem,
            this.pageReplacementToolStripMenuItem});
            this.processSchedulingToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.processSchedulingToolStripMenuItem.Name = "processSchedulingToolStripMenuItem";
            this.processSchedulingToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.processSchedulingToolStripMenuItem.Text = "Menu";
            this.processSchedulingToolStripMenuItem.Click += new System.EventHandler(this.processSchedulingToolStripMenuItem_Click);
            // 
            // processSchedulingToolStripMenuItem1
            // 
            this.processSchedulingToolStripMenuItem1.Name = "processSchedulingToolStripMenuItem1";
            this.processSchedulingToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.processSchedulingToolStripMenuItem1.Text = "Process Scheduling";
            this.processSchedulingToolStripMenuItem1.Click += new System.EventHandler(this.processSchedulingToolStripMenuItem1_Click);
            // 
            // fixedPartitionToolStripMenuItem
            // 
            this.fixedPartitionToolStripMenuItem.Name = "fixedPartitionToolStripMenuItem";
            this.fixedPartitionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fixedPartitionToolStripMenuItem.Text = "Fixed Partition";
            this.fixedPartitionToolStripMenuItem.Click += new System.EventHandler(this.fixedPartitionToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            // 
            // panel_view
            // 
            this.panel_view.Location = new System.Drawing.Point(0, 27);
            this.panel_view.Name = "panel_view";
            this.panel_view.Size = new System.Drawing.Size(984, 478);
            this.panel_view.TabIndex = 1;
            // 
            // pageReplacementToolStripMenuItem
            // 
            this.pageReplacementToolStripMenuItem.Name = "pageReplacementToolStripMenuItem";
            this.pageReplacementToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pageReplacementToolStripMenuItem.Text = "Page Replacement";
            this.pageReplacementToolStripMenuItem.Click += new System.EventHandler(this.pageReplacementToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 506);
            this.Controls.Add(this.panel_view);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "OS Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processSchedulingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.Panel panel_view;
        private System.Windows.Forms.ToolStripMenuItem fixedPartitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageReplacementToolStripMenuItem;
    }
}

