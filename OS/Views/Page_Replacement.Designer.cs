namespace OS
{
    partial class Page_Replacement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.frames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.i_string = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_SR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_FR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. of Frames:";
            // 
            // frames
            // 
            this.frames.Location = new System.Drawing.Point(35, 210);
            this.frames.Name = "frames";
            this.frames.Size = new System.Drawing.Size(160, 21);
            this.frames.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(32, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "String:";
            // 
            // i_string
            // 
            this.i_string.Location = new System.Drawing.Point(35, 154);
            this.i_string.Name = "i_string";
            this.i_string.Size = new System.Drawing.Size(160, 21);
            this.i_string.TabIndex = 8;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle1;
            this.table.Location = new System.Drawing.Point(218, 72);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(743, 252);
            this.table.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Page Replacement";
            // 
            // process
            // 
            this.process.FormattingEnabled = true;
            this.process.Items.AddRange(new object[] {
            "FIFO",
            "Optimal"});
            this.process.Location = new System.Drawing.Point(35, 102);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(160, 21);
            this.process.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(32, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Process:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(764, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Success Ratio:";
            // 
            // text_SR
            // 
            this.text_SR.Location = new System.Drawing.Point(767, 371);
            this.text_SR.Name = "text_SR";
            this.text_SR.ReadOnly = true;
            this.text_SR.Size = new System.Drawing.Size(160, 21);
            this.text_SR.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(569, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Failure Ratio:";
            // 
            // text_FR
            // 
            this.text_FR.Location = new System.Drawing.Point(572, 371);
            this.text_FR.Name = "text_FR";
            this.text_FR.ReadOnly = true;
            this.text_FR.Size = new System.Drawing.Size(160, 21);
            this.text_FR.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(226, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "* = Failure";
            // 
            // Page_Replacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_SR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_FR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.process);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.i_string);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Page_Replacement";
            this.Size = new System.Drawing.Size(984, 478);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox i_string;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox process;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_SR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_FR;
        private System.Windows.Forms.Label label7;
    }
}
