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
    public partial class Page_Replacement : UserControl
    {

        int string_length;
        int no_frame;
        string pages;
        public Page_Replacement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(i_string.Text=="" || frames.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (frames.Text == "0")
            {
                MessageBox.Show("No of Frames is not valid!", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (process.Text == "FIFO")
                {
                    FIFO();
                }
                else if (process.Text == "Optimal")
                {
                    opt();
                }
                else
                {
                    MessageBox.Show("Process is not valid!", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            

            table.AutoResizeColumns();
        }


        void opt()
        {
            pages = i_string.Text;
            string_length = pages.Length;
            no_frame = int.Parse(frames.Text);
            int[] arrframes = new int[no_frame];
            int i, j = 0, k, max, faults=0;
            int[] duration = new int[no_frame];
            int[] flag = new int[no_frame];
            bool found = false;
            int temp_faults = 0;

            table.Rows.Clear();
            table.Columns.Clear();

            for (i = 0; i < no_frame; ++i)
            {
                arrframes[i] = -1;
            }


            for (i = 0; i < string_length; i++)
            {
                table.Columns.Add("p" + pages.ElementAt(i), "" + pages.ElementAt(i));
            }
            for (i = 0; i <= no_frame; i++)
            {
                table.Rows.Add();
            }

            for (i = 0; i < string_length; i++)
            {
                for (j = 0; j < no_frame; j++)
                {
                    flag[j] = 0;
                    duration[j] = string_length;
                }

                for (k = i + 1; k < string_length; k++)
                {
                    for (j = 0; j < no_frame; j++)
                        if (int.Parse(pages[k].ToString()) == arrframes[j] && flag[j] == 0)
                        {
                            duration[j] = k;
                            flag[j] = 1;
                        }
                }

                for (j = 0; j < no_frame; j++)
                    if (int.Parse(pages[i].ToString()) == arrframes[j])
                        found = true;
                if (found == false)
                {
                    max = 0;
                    for (j = 0; j < no_frame; j++)
                    {
                        if (duration[j] > duration[max])
                            max = j;
                        if (arrframes[j] < 0)
                        {
                            max = j;
                            break;
                        }
                    }
                    arrframes[max] = int.Parse(pages[i].ToString());
                    faults++;
                }
                for (int frames = 0; frames < no_frame; frames++)
                {
                    table.Rows[frames].Cells[i].Value = arrframes[frames];
                    if (arrframes[frames] == -1)
                    {
                        table.Rows[frames].Cells[i].Value = "";
                    }
                    if (faults > temp_faults)
                    {
                        table.Rows[no_frame].Cells[i].Value = "*";
                        temp_faults = faults;
                    }
                }

                found = false;

            }

            int FR = faults;
            int SR = (string_length - faults);

            text_FR.Text = FR.ToString() + "/" + string_length;
            text_SR.Text = SR.ToString() + "/" + string_length;

        }


        void Optimal()
        {
            pages = i_string.Text;
            string_length = pages.Length;
            no_frame = int.Parse(frames.Text);
            int[] arrframes = new int[no_frame];
            int[] arrtemp = new int[no_frame];
            int flag1, flag2, flag3, i, j, k, pos=0, max, faults = 0;
            int temp_faults=0;

            table.Rows.Clear();
            table.Columns.Clear();

            for (i = 0; i < string_length; i++)
            {
                table.Columns.Add("p" + pages.ElementAt(i), "" + pages.ElementAt(i));
            }
            for (i = 0; i <= no_frame; i++)
            {
                table.Rows.Add();
            }

            for (i = 0; i < no_frame; ++i)
            {
                arrframes[i] = -1;
            }
            for (i = 0; i < string_length; ++i)
            {
                int page = int.Parse(pages[i].ToString());
                flag1 = flag2 = 0;

                for (j = 0; j < no_frame; ++j)
                {
                    if (arrframes[j] == page)
                    {
                        flag1 = flag2 = 1;
                        break;
                    }
                }

                if (flag1 == 0)
                {
                    for (j = 0; j < no_frame; ++j)
                    {
                        if (arrframes[j] == -1)
                        {
                            faults++;
                            arrframes[j] = page;
                            flag2 = 1;
                            break;
                        }
                    }
                }

                if (flag2 == 0)
                {
                    flag3 = 0;

                    for (j = 0; j < no_frame; ++j)
                    {
                        arrtemp[j] = -1;

                        for (k = i + 1; k < no_frame; ++k)
                        {
                            if (arrframes[j] == page)
                            {
                                arrtemp[j] = k;
                                break;
                            }
                        }
                    }

                    for (j = 0; j < no_frame; ++j)
                    {
                        if (arrtemp[j] == -1)
                        {
                            pos = j;
                            flag3 = 1;
                            break;
                        }
                    }

                    if (flag3 == 0)
                    {
                        max = arrtemp[0];
                        pos = 0;

                        for (j = 1; j < no_frame; ++j)
                        {
                            if (arrtemp[j] > max)
                            {
                                max = arrtemp[j];
                                pos = j;
                            }
                        }
                    }

                    arrframes[pos] = page;
                    faults++;
                }
                for (j = 0; j < no_frame; ++j)
                {
                    table.Rows[j].Cells[i].Value = arrframes[j];
                    if (arrframes[j] == -1)
                    {
                        table.Rows[j].Cells[i].Value = "";

                    }
                    if (faults>temp_faults)
                    {
                        table.Rows[no_frame].Cells[i].Value = "*";
                        temp_faults = faults;
                    }
                }
            }

            int FR = faults;
            int SR = (string_length - faults);

            text_FR.Text = FR.ToString() + "/" + string_length;
            text_SR.Text = SR.ToString() + "/" + string_length;
        }

        void FIFO()
        {
            pages = i_string.Text;
            string_length = pages.Length;
            no_frame = int.Parse(frames.Text);
            int[] arrFrames = new int[no_frame];
            int num = 0, pageHit = 0;
            int i;
            bool flag = true;
            


            table.Rows.Clear();
            table.Columns.Clear();

            for (i = 0; i < string_length; i++)
            {
                table.Columns.Add("p" + pages.ElementAt(i), "" + pages.ElementAt(i));
            }
            for (i = 0; i <= no_frame; i++)
            {
                table.Rows.Add();
            }

            for (i = 0; i < no_frame; i++)
            {
                arrFrames[i] = -1;
            }

            for (i = 0; i < string_length; i++)
            {
                flag = true;
                int page = int.Parse(pages[i].ToString());
                for (int j = 0; j < no_frame; j++)
                {
                    if (arrFrames[j] == page)
                    {
                        flag = false;
                        pageHit++;
                        break;
                    }
                }
                if (num == no_frame)
                {
                    num = 0;
                }
                if (flag)
                {
                    arrFrames[num] = page;
                    num++;
                }

                for (int k = 0; k < no_frame; k++)
                {

                    table.Rows[k].Cells[i].Value = arrFrames[k];
                    if (arrFrames[k] == -1)
                    {
                        table.Rows[k].Cells[i].Value = "";
                    }
                    if (flag)
                    {
                        table.Rows[no_frame].Cells[i].Value = "*";
                    }
                }
            }

            int SR = pageHit;
            int FR = (string_length - pageHit);

            text_FR.Text = FR.ToString()+"/"+string_length;
            text_SR.Text = SR.ToString() + "/" + string_length;

        }
    }
}
