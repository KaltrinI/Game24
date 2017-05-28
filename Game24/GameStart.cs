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
    public partial class GameStart : Form
    {
        String name;
        public GameStart(string n)
        {
            InitializeComponent();
            name = n;
            lblName.Text = "Hello " + name;
        }

        private void btn_practice_Click(object sender, EventArgs e)
        {
            Hide();
            Form pr = new Form1();
            pr.ShowDialog();
            Show();
            
        }

        private void btn_TimeAt_Click(object sender, EventArgs e)
        {
            Hide();
            Form pr = new TimeAttack(name);
            pr.ShowDialog();
            Show();

        }

        private void btn_BestOf_Click(object sender, EventArgs e)
        {
            Hide();
            Form pr = new BrainCrunch(name);
            pr.ShowDialog();
            Show();
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

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
