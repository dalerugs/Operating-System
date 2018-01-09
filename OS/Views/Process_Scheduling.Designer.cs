namespace OS
{
    partial class Process_Scheduling
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
            this.label_TQ = new System.Windows.Forms.Label();
            this.textBox_TQ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_Priority = new System.Windows.Forms.TextBox();
            this.textBox_BT = new System.Windows.Forms.TextBox();
            this.textBox_AT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_PNO = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_NoOfProcess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_techniques = new System.Windows.Forms.ComboBox();
            this.gantt = new System.Windows.Forms.DataGridView();
            this.button_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_avgWT = new System.Windows.Forms.Label();
            this.label_avgTAT = new System.Windows.Forms.Label();
            this.label_Techniques = new System.Windows.Forms.Label();
            this.button_Process = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.tPNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gantt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TQ
            // 
            this.label_TQ.AutoSize = true;
            this.label_TQ.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_TQ.Location = new System.Drawing.Point(21, 187);
            this.label_TQ.Name = "label_TQ";
            this.label_TQ.Size = new System.Drawing.Size(40, 19);
            this.label_TQ.TabIndex = 112;
            this.label_TQ.Text = "TQ*";
            // 
            // textBox_TQ
            // 
            this.textBox_TQ.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox_TQ.Location = new System.Drawing.Point(93, 185);
            this.textBox_TQ.Name = "textBox_TQ";
            this.textBox_TQ.Size = new System.Drawing.Size(97, 25);
            this.textBox_TQ.TabIndex = 111;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button1.Location = new System.Drawing.Point(25, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 110;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button_Update.Location = new System.Drawing.Point(115, 412);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 27);
            this.button_Update.TabIndex = 109;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_Priority
            // 
            this.textBox_Priority.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox_Priority.Location = new System.Drawing.Point(93, 366);
            this.textBox_Priority.Name = "textBox_Priority";
            this.textBox_Priority.Size = new System.Drawing.Size(97, 25);
            this.textBox_Priority.TabIndex = 108;
            // 
            // textBox_BT
            // 
            this.textBox_BT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox_BT.Location = new System.Drawing.Point(93, 329);
            this.textBox_BT.Name = "textBox_BT";
            this.textBox_BT.Size = new System.Drawing.Size(97, 25);
            this.textBox_BT.TabIndex = 107;
            // 
            // textBox_AT
            // 
            this.textBox_AT.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textBox_AT.Location = new System.Drawing.Point(93, 292);
            this.textBox_AT.Name = "textBox_AT";
            this.textBox_AT.Size = new System.Drawing.Size(97, 25);
            this.textBox_AT.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(21, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(21, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 104;
            this.label5.Text = "BT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(21, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 103;
            this.label4.Text = "AT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(21, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 102;
            this.label3.Text = "PNO";
            // 
            // combobox_PNO
            // 
            this.combobox_PNO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.combobox_PNO.FormattingEnabled = true;
            this.combobox_PNO.Location = new System.Drawing.Point(93, 257);
            this.combobox_PNO.Name = "combobox_PNO";
            this.combobox_PNO.Size = new System.Drawing.Size(97, 26);
            this.combobox_PNO.TabIndex = 101;
            this.combobox_PNO.SelectedIndexChanged += new System.EventHandler(this.combobox_PNO_SelectedIndexChanged);
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button_OK.Location = new System.Drawing.Point(115, 128);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 28);
            this.button_OK.TabIndex = 100;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "No. of Processes*";
            // 
            // combobox_NoOfProcess
            // 
            this.combobox_NoOfProcess.Font = new System.Drawing.Font("Tahoma", 11F);
            this.combobox_NoOfProcess.FormattingEnabled = true;
            this.combobox_NoOfProcess.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combobox_NoOfProcess.Location = new System.Drawing.Point(25, 90);
            this.combobox_NoOfProcess.Name = "combobox_NoOfProcess";
            this.combobox_NoOfProcess.Size = new System.Drawing.Size(165, 26);
            this.combobox_NoOfProcess.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "Technique*";
            // 
            // combobox_techniques
            // 
            this.combobox_techniques.Font = new System.Drawing.Font("Tahoma", 11F);
            this.combobox_techniques.FormattingEnabled = true;
            this.combobox_techniques.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "SRTF",
            "NPP",
            "PP",
            "RR"});
            this.combobox_techniques.Location = new System.Drawing.Point(25, 34);
            this.combobox_techniques.Name = "combobox_techniques";
            this.combobox_techniques.Size = new System.Drawing.Size(165, 26);
            this.combobox_techniques.TabIndex = 96;
            // 
            // gantt
            // 
            this.gantt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gantt.DefaultCellStyle = dataGridViewCellStyle1;
            this.gantt.Location = new System.Drawing.Point(242, 360);
            this.gantt.Name = "gantt";
            this.gantt.RowHeadersVisible = false;
            this.gantt.Size = new System.Drawing.Size(717, 101);
            this.gantt.TabIndex = 123;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button_clear.Location = new System.Drawing.Point(435, 262);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(141, 28);
            this.button_clear.TabIndex = 122;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(534, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 121;
            this.label7.Text = "G A N T T  C H A R T";
            // 
            // label_avgWT
            // 
            this.label_avgWT.AutoSize = true;
            this.label_avgWT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_avgWT.Location = new System.Drawing.Point(842, 133);
            this.label_avgWT.Name = "label_avgWT";
            this.label_avgWT.Size = new System.Drawing.Size(0, 19);
            this.label_avgWT.TabIndex = 120;
            // 
            // label_avgTAT
            // 
            this.label_avgTAT.AutoSize = true;
            this.label_avgTAT.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_avgTAT.Location = new System.Drawing.Point(842, 100);
            this.label_avgTAT.Name = "label_avgTAT";
            this.label_avgTAT.Size = new System.Drawing.Size(0, 19);
            this.label_avgTAT.TabIndex = 119;
            // 
            // label_Techniques
            // 
            this.label_Techniques.AutoSize = true;
            this.label_Techniques.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Techniques.Location = new System.Drawing.Point(842, 60);
            this.label_Techniques.Name = "label_Techniques";
            this.label_Techniques.Size = new System.Drawing.Size(0, 19);
            this.label_Techniques.TabIndex = 118;
            // 
            // button_Process
            // 
            this.button_Process.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button_Process.Location = new System.Drawing.Point(582, 262);
            this.button_Process.Name = "button_Process";
            this.button_Process.Size = new System.Drawing.Size(141, 28);
            this.button_Process.TabIndex = 116;
            this.button_Process.Text = "Process";
            this.button_Process.UseVisualStyleBackColor = true;
            this.button_Process.Click += new System.EventHandler(this.button_Process_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(743, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 117;
            this.label13.Text = "Technique:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(750, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 115;
            this.label12.Text = "Avg . WT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(743, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 114;
            this.label11.Text = "Avg . TAT:";
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.AllowUserToAddRows = false;
            this.dataGridView_table.AllowUserToDeleteRows = false;
            this.dataGridView_table.AllowUserToOrderColumns = true;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tPNO,
            this.tAT,
            this.tBT,
            this.tPriority,
            this.tRT,
            this.tCT,
            this.tTAT,
            this.tWT});
            this.dataGridView_table.Location = new System.Drawing.Point(242, 12);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.RowHeadersVisible = false;
            this.dataGridView_table.Size = new System.Drawing.Size(481, 244);
            this.dataGridView_table.TabIndex = 113;
            // 
            // tPNO
            // 
            this.tPNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tPNO.HeaderText = "PNO";
            this.tPNO.Name = "tPNO";
            this.tPNO.ReadOnly = true;
            this.tPNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tAT
            // 
            this.tAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tAT.HeaderText = "AT";
            this.tAT.Name = "tAT";
            this.tAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tBT
            // 
            this.tBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tBT.HeaderText = "BT";
            this.tBT.Name = "tBT";
            this.tBT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tPriority
            // 
            this.tPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tPriority.HeaderText = "Priority";
            this.tPriority.Name = "tPriority";
            this.tPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tRT
            // 
            this.tRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tRT.HeaderText = "RT";
            this.tRT.Name = "tRT";
            this.tRT.ReadOnly = true;
            this.tRT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tCT
            // 
            this.tCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tCT.HeaderText = "CT";
            this.tCT.Name = "tCT";
            this.tCT.ReadOnly = true;
            this.tCT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tTAT
            // 
            this.tTAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tTAT.HeaderText = "TAT";
            this.tTAT.Name = "tTAT";
            this.tTAT.ReadOnly = true;
            this.tTAT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tWT
            // 
            this.tWT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tWT.HeaderText = "WT";
            this.tWT.Name = "tWT";
            this.tWT.ReadOnly = true;
            this.tWT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Process_Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gantt);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_avgWT);
            this.Controls.Add(this.label_avgTAT);
            this.Controls.Add(this.label_Techniques);
            this.Controls.Add(this.button_Process);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView_table);
            this.Controls.Add(this.label_TQ);
            this.Controls.Add(this.textBox_TQ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_Priority);
            this.Controls.Add(this.textBox_BT);
            this.Controls.Add(this.textBox_AT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobox_PNO);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combobox_NoOfProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_techniques);
            this.Name = "Process_Scheduling";
            this.Size = new System.Drawing.Size(984, 478);
            ((System.ComponentModel.ISupportInitialize)(this.gantt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TQ;
        private System.Windows.Forms.TextBox textBox_TQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_Priority;
        private System.Windows.Forms.TextBox textBox_BT;
        private System.Windows.Forms.TextBox textBox_AT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_PNO;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_NoOfProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_techniques;
        private System.Windows.Forms.DataGridView gantt;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_avgWT;
        private System.Windows.Forms.Label label_avgTAT;
        private System.Windows.Forms.Label label_Techniques;
        private System.Windows.Forms.Button button_Process;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tWT;
    }
}
