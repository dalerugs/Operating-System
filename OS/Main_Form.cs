using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class Main_Form : Form
    {
        Process_Scheduling process_scheduling;
        Fixed_Partition fixed_partition;
        Page_Replacement page_replacement;
        public Main_Form()
        {
            InitializeComponent();
            reset();
        }

        void reset()
        {
            process_scheduling = new Process_Scheduling();
            fixed_partition = new Fixed_Partition();
            page_replacement = new Page_Replacement();
            panel_view.Controls.Add(process_scheduling);

        }

        private void processSchedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void processSchedulingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            panel_view.Controls.Add(process_scheduling);
        }

        private void fixedPartitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            panel_view.Controls.Add(fixed_partition);
        }

        private void pageReplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_view.Controls.Clear();
            panel_view.Controls.Add(page_replacement);
        }
    }
}
