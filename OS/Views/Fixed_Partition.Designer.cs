namespace OS
{
    partial class Fixed_Partition
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
            this.components = new System.ComponentModel.Container();
            this.gridPartition = new System.Windows.Forms.DataGridView();
            this.noOfPart = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noOfJobs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridJobs = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.partNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPartition
            // 
            this.gridPartition.AllowUserToAddRows = false;
            this.gridPartition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNo,
            this.partSize,
            this.partJob});
            this.gridPartition.Location = new System.Drawing.Point(277, 65);
            this.gridPartition.Name = "gridPartition";
            this.gridPartition.RowHeadersVisible = false;
            this.gridPartition.Size = new System.Drawing.Size(353, 370);
            this.gridPartition.TabIndex = 0;
            // 
            // noOfPart
            // 
            this.noOfPart.Location = new System.Drawing.Point(39, 104);
            this.noOfPart.Name = "noOfPart";
            this.noOfPart.Size = new System.Drawing.Size(160, 21);
            this.noOfPart.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. Of Partition";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "No. of Jobs";
            // 
            // noOfJobs
            // 
            this.noOfJobs.Location = new System.Drawing.Point(39, 160);
            this.noOfJobs.Name = "noOfJobs";
            this.noOfJobs.Size = new System.Drawing.Size(160, 21);
            this.noOfJobs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partitions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jobs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gridJobs
            // 
            this.gridJobs.AllowUserToAddRows = false;
            this.gridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobno,
            this.jobSize});
            this.gridJobs.Location = new System.Drawing.Point(692, 65);
            this.gridJobs.Name = "gridJobs";
            this.gridJobs.RowHeadersVisible = false;
            this.gridJobs.Size = new System.Drawing.Size(246, 370);
            this.gridJobs.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button3.Location = new System.Drawing.Point(44, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Process";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button4.Location = new System.Drawing.Point(44, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "Reset All";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // partNo
            // 
            this.partNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partNo.HeaderText = "Partition #";
            this.partNo.Name = "partNo";
            this.partNo.ReadOnly = true;
            // 
            // partSize
            // 
            this.partSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partSize.HeaderText = "Size";
            this.partSize.Name = "partSize";
            // 
            // partJob
            // 
            this.partJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partJob.HeaderText = "Job";
            this.partJob.Name = "partJob";
            this.partJob.ReadOnly = true;
            // 
            // jobno
            // 
            this.jobno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobno.HeaderText = "Job #";
            this.jobno.Name = "jobno";
            this.jobno.ReadOnly = true;
            // 
            // jobSize
            // 
            this.jobSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobSize.HeaderText = "Size";
            this.jobSize.Name = "jobSize";
            // 
            // Fixed_Partition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gridJobs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noOfJobs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noOfPart);
            this.Controls.Add(this.gridPartition);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Fixed_Partition";
            this.Size = new System.Drawing.Size(984, 478);
            ((System.ComponentModel.ISupportInitialize)(this.gridPartition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPartition;
        private System.Windows.Forms.TextBox noOfPart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOfJobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridJobs;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn partSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn partJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobno;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobSize;
    }
}
