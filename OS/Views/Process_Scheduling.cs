using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Process_Scheduling : UserControl
    {
        public static int[,] data = new int[10, 8];
        public static int noProcess;
        public Process_Scheduling()
        {
            InitializeComponent();
            reset();
        }

        void GanttChart(int[,] arrCTRT)
        {
            gantt.Columns.Clear();
            for (int i = 0; i < FCFS.calcTBT(); i++)
            {
                if (arrCTRT[i, 1] > 0)
                {
                    gantt.Columns.Add("time" + i, "" + i);
                    gantt.Rows[0].Cells["time" + i].Value = "P" + arrCTRT[i, 1];
                    ChangeColor("time" + i, arrCTRT[i, 1]);
                }
            }
            gantt.Columns.Add("time" + (FCFS.calcTBT() - 1), "" + (FCFS.calcTBT() - 1));
            gantt.Rows[0].Cells["time" + (FCFS.calcTBT() - 1)].Style.BackColor = Color.Black;

        }

        void ChangeColor(string index, int PNO)
        {
            if (PNO == 1)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.AliceBlue;
            }
            else if (PNO == 2)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.BlanchedAlmond;
            }
            else if (PNO == 3)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.Chartreuse;
            }
            else if (PNO == 4)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.Coral;
            }
            else if (PNO == 5)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.Crimson;
            }
            else if (PNO == 6)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.ForestGreen;
            }
            else if (PNO == 7)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.Goldenrod;
            }
            else if (PNO == 8)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.LightSkyBlue;
            }
            else if (PNO == 9)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.LightPink;
            }
            else if (PNO == 10)
            {
                gantt.Rows[0].Cells[index].Style.BackColor = Color.PapayaWhip;
            }
        }

        void reset()
        {

            combobox_PNO.Enabled = false;
            textBox_AT.Enabled = false;
            textBox_BT.Enabled = false;
            textBox_Priority.Enabled = false;
            button_Update.Enabled = false;
            button_Process.Enabled = false;
            button_clear.Enabled = false;
            textBox_TQ.Hide();
            label_TQ.Hide();
            Array.Clear(data, 0, data.Length);
            dataGridView_table.Rows.Clear();
        }
        void finalize()
        {
            calcTAT();
            calcWT();

            dataGridView_table.Rows.Clear();
            for (int i = 0; i < int.Parse(combobox_NoOfProcess.Text); i++)
            {
                dataGridView_table.Rows.Add(i + 1, data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5], data[i, 6], data[i, 7]);
            }
        }

        void calcTAT()
        {
            float avgTAT = 0;
            for (int i = 0; i < noProcess; i++)
            {
                data[i, 6] = data[i, 5] - data[i, 1];
            }
            for (int i = 0; i < noProcess; i++)
            {
                avgTAT = avgTAT + data[i, 6];
            }
            label_avgTAT.Text = "" + (avgTAT / noProcess);

        }
        void calcWT()
        {
            float avgWT = 0;
            for (int i = 0; i < noProcess; i++)
            {
                data[i, 7] = data[i, 6] - data[i, 2];
            }
            for (int i = 0; i < noProcess; i++)
            {
                avgWT = avgWT + data[i, 7];
            }
            label_avgWT.Text = "" + (avgWT / noProcess);
        }

        private void button_OK_Click_1(object sender, EventArgs e)
        {
            if (combobox_techniques.Text == "")
            {
                MessageBox.Show("Technique is empty: Please fill the required fields", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combobox_NoOfProcess.Text == "")
            {
                MessageBox.Show("No of Process is empty: Please fill the required fields", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (combobox_techniques.Text == "RR")
                {
                    textBox_TQ.Show();
                    label_TQ.Show();
                }
                combobox_PNO.Enabled = true;
                textBox_AT.Enabled = true;
                textBox_BT.Enabled = true;
                textBox_Priority.Enabled = true;
                button_Update.Enabled = true;
                button_Process.Enabled = true;
                button_clear.Enabled = true;
                noProcess = int.Parse(combobox_NoOfProcess.Text);
                label_Techniques.Text = combobox_techniques.Text;
                combobox_PNO.Items.Clear();
                for (int i = 1; i <= int.Parse(combobox_NoOfProcess.Text); i++)
                {
                    combobox_PNO.Items.Add(i);
                }

                dataGridView_table.Rows.Clear();
                for (int i = 0; i < int.Parse(combobox_NoOfProcess.Text); i++)
                {
                    dataGridView_table.Rows.Add(i + 1, data[i, 1], data[i, 2], data[i, 3]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void combobox_PNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_AT.Text = "" + data[int.Parse(combobox_PNO.Text) - 1, 1];
            textBox_BT.Text = "" + data[int.Parse(combobox_PNO.Text) - 1, 2];
            textBox_Priority.Text = "" + data[int.Parse(combobox_PNO.Text) - 1, 3];
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (combobox_PNO.Text == "")
            {
                MessageBox.Show("PNO is empty: Please select process number first.", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_AT.Text == "" || textBox_BT.Text == "" || textBox_Priority.Text == "")
            {
                MessageBox.Show("Empty field: Please fill AT, BT and Priority.", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combobox_techniques.Text == "PP" || combobox_techniques.Text == "NPP" && int.Parse(textBox_Priority.Text) <= 0 && int.Parse(textBox_Priority.Text) > 5)
            {
                MessageBox.Show("Invalid Input: Priority must be greater than 0 and less than 5", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int pno = int.Parse(combobox_PNO.Text) - 1;
                data[pno, 0] = pno + 1;
                data[pno, 1] = int.Parse(textBox_AT.Text);
                data[pno, 2] = int.Parse(textBox_BT.Text);
                data[pno, 3] = int.Parse(textBox_Priority.Text);

                dataGridView_table.Rows.Clear();
                for (int i = 0; i < int.Parse(combobox_NoOfProcess.Text); i++)
                {
                    dataGridView_table.Rows.Add(i + 1, data[i, 1], data[i, 2], data[i, 3]);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Array.Clear(data, 0, data.Length);
            dataGridView_table.Rows.Clear();
            for (int i = 0; i < int.Parse(combobox_NoOfProcess.Text); i++)
            {
                dataGridView_table.Rows.Add(i + 1, data[i, 1], data[i, 2], data[i, 3]);
            }
        }

        private void button_Process_Click(object sender, EventArgs e)
        {
          
            label_Techniques.Text = combobox_techniques.Text;
            if (combobox_techniques.Text == "FCFS")
            {
                FCFS.doFCFS();
                GanttChart(FCFS.arrCTRT);
                finalize();

            }
            else if (combobox_techniques.Text == "SJF")
            {
                SJF.doSJF();
                GanttChart(SJF.arrCTRT);
                finalize();

            }
            else if (combobox_techniques.Text == "NPP")
            {
                NPP.doNPP();
                GanttChart(NPP.arrCTRT);
                finalize();
            }
            else if (combobox_techniques.Text == "SRTF")
            {
                SRTF.doSRTF();
                GanttChart(SRTF.arrCTRT);
                finalize();
            }
            else if (combobox_techniques.Text == "PP")
            {
                PP.doPP();
                GanttChart(PP.arrCTRT);
                finalize();
            }
            else if (combobox_techniques.Text == "RR")
            {
                if (textBox_TQ.Text == "")
                {
                    MessageBox.Show("Time Quantum is empty: Please fill the required fields", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_TQ.Show();
                    label_TQ.Show();
                }
                else if (int.Parse(textBox_TQ.Text) <= 0)
                {
                    MessageBox.Show("Invalid Input: Time quantum must be greater than 0", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RR.doRR(int.Parse(textBox_TQ.Text));
                    GanttChart(RR.arrCTRT);
                    finalize();
                }

            }
        }
    }
}
