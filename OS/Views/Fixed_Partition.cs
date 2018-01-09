using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OS
{
    public partial class Fixed_Partition : UserControl
    {
        int noPartitions;
        int noJobs;

        int[,] tempParts = new int[100, 3];
        int[,] tempJobs = new int[100, 2];
        static ArrayList CopyJobs = new ArrayList();

        public Fixed_Partition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noOfPart.Text = gridPartition.Rows[0].Cells["Column1"].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            noPartitions = int.Parse(noOfPart.Text);
            noJobs = int.Parse(noOfJobs.Text);
            gridPartition.Rows.Clear();
            gridJobs.Rows.Clear();

            for (int i = 0; i < noPartitions; i++)
            {
                gridPartition.Rows.Add(i + 1, tempParts[i, 1]);
            }
            for (int i = 0; i < noJobs; i++)
            {
                gridJobs.Rows.Add(i + 1, tempJobs[i, 1]);
            }
        }

        int PickProcess(int partitionSize)
        {
            ArrayList Choices = new ArrayList();
            for (int j = 0; j < CopyJobs.Count; j++)
            {
                if (tempJobs[(int)CopyJobs[j]-1, 1] <= partitionSize)
                {
                    Choices.Add(CopyJobs[j]);
                }
            }

            int best = 0 ;

            if (Choices.Count > 0)
            {
                best = (int)Choices[0];
                for (int j = 0; j < Choices.Count; j++)
                {
                    if ((partitionSize - tempJobs[best - 1, 1]) > (partitionSize - tempJobs[(int)Choices[j] - 1, 1]))
                    {
                        best = (int)Choices[j];
                    }
                }
                CopyJobs.Remove(best);
            }

            
            return best;
       }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < noPartitions; i++)
            {
                tempParts[i, 0] = int.Parse(gridPartition.Rows[i].Cells["partNo"].Value.ToString());
                tempParts[i, 1] = int.Parse(gridPartition.Rows[i].Cells["partSize"].Value.ToString());
            }
            for (int i = 0; i < noJobs; i++)
            {
                tempJobs[i, 0] = int.Parse(gridJobs.Rows[i].Cells["jobno"].Value.ToString());
                tempJobs[i, 1] = int.Parse(gridJobs.Rows[i].Cells["jobSize"].Value.ToString());
                
            }
            for (int i = 0; i < noJobs; i++)
            {
                CopyJobs.Add(tempJobs[i,0]);
            }


            for (int i = 0; i < noPartitions; i++)
            {
                tempParts[i, 2] = PickProcess(tempParts[i, 1]);
            }

            





            gridPartition.Rows.Clear();

            for (int i = 0; i < noPartitions; i++)
            {
                gridPartition.Rows.Add(i + 1, tempParts[i, 1],"Job "+ tempParts[i, 2]);
            }




        }
    }
}
