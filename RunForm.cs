using System;
using System.Windows.Forms;

namespace Runmono
{
    public partial class RunFormDesign : Form
    {
        public RunFormDesign()
        {
            Init();
        }

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void run_Click(object sender, EventArgs e)
        {
            Run(txt.Text);
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                Run(txt.Text);
                this.Close();
            }
        }

        private void Run(string Process)
        {
            System.Diagnostics.Process.Start(txt.Text);
        }
    }
}