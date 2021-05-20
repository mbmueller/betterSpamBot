using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betterSpamBot
{
    public partial class betterSpamBot : Form
    {
        public betterSpamBot()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!msg0.Text.Equals(""))
            {
                SendKeys.Send(msg0.Text);
                SendKeys.Send("{Enter}");
            }
            if (!msg1.Text.Equals(""))
            {
                SendKeys.Send(msg1.Text);
                SendKeys.Send("{Enter}");
            }
            if (!msg2.Text.Equals(""))
            {
                SendKeys.Send(msg2.Text);
                SendKeys.Send("{Enter}");
            }
            if (!msg3.Text.Equals(""))
            {
                SendKeys.Send(msg3.Text);
                SendKeys.Send("{Enter}");
            }
        }
    }
}
