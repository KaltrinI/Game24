using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game24
{
    public partial class LoadScene : Form
    {
        public LoadScene()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Form pr = new HowToPlay();
            pr.ShowDialog();
            Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Form pr = new GameStart(textBox1.Text);
            pr.ShowDialog();
            Show();
        }

      
        private void label3_Click(object sender, EventArgs e)
        {
            //No time for this :(
        }

       

    }
}
