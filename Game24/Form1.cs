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
    public partial class Form1 : Form
    {
        
        static int count;
        static int correct;
        bool flag;
        bool flag2;
        Game24 game;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card1.Text;
                Card1.Enabled = false;
                flag = false;
                checkEvaluate();
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card2.Text;
                Card2.Enabled = false;
                flag = false;
                checkEvaluate();
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card3.Text;
                Card3.Enabled = false;
                flag = false;
                checkEvaluate();
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card4.Text;
                Card4.Enabled = false;
                flag = false;
                checkEvaluate();
            }
        }

        private void checkEvaluate() {
            if (Card2.Enabled == false && Card1.Enabled == false && Card3.Enabled == false && Card4.Enabled == false)
                btnEvaluate.Enabled = true;
        
        }

        private void op1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                label2.Text += op1.Text;
                flag = true;
            }
        }

        private void op2_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                label2.Text += op2.Text;
                flag = true;

            }
        }

        private void op3_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                label2.Text += op3.Text;
                flag = true;
            }
        }

        private void op4_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                label2.Text += op4.Text;
                flag = true;
            }
        }

        private void opb_Click(object sender, EventArgs e)
        {
            if (flag)
                label2.Text += opb.Text;

        }

        private void clb_Click(object sender, EventArgs e)
        {
            if (!flag)
                label2.Text += clb.Text;

        }

        private void Generate() {
            this.Focus();
            
            game.Generate();
            Card1.Text = game.Card1.ToString();
            Card2.Text = game.Card2.ToString();
            Card3.Text = game.Card3.ToString();
            Card4.Text = game.Card4.ToString();
            clearAll();
        }

        public void clearAll() {
            Card1.Enabled = true;
            Card2.Enabled = true;
            Card3.Enabled = true;
            Card4.Enabled = true;
            label2.Text = "";
            btnEvaluate.Enabled = false;
            btnShowS.Enabled = true;
            label3.Text = "";
            flag2 = false;
            flag = true;
        
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void btnEvalute_Click(object sender, EventArgs e)
        {
            
            try
            {
                var v = dt.Compute(label2.Text, "");

                if (v.ToString() == "24")
                {

                    MessageBox.Show("Correct!");
                    clearAll();
                    btnGenerate.Focus();
                }
                else
                {
                    MessageBox.Show("Try again");
                    clearAll();
                }
            }
            catch
            {
                MessageBox.Show("Error in expression format");
                clearAll();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
           
        }

       

        private void btnShowS_Click(object sender, EventArgs e)
        {
            label3.Text = game.getSolution();
            flag2 = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = true;
            flag2 = false;
            correct = 0;
            count = 0;
            game = new Game24();
            this.KeyPreview = true;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals(Card1.Text) || e.KeyChar.ToString().Equals(Card2.Text) || e.KeyChar.ToString().Equals(Card3.Text) || e.KeyChar.ToString().Equals(Card4.Text))
            {
                if (Card1.Enabled && e.KeyChar.ToString().Equals(Card1.Text))
                    Card1_Click(null, null);
                else if (Card2.Enabled && e.KeyChar.ToString().Equals(Card2.Text))
                    Card2_Click(null, null);
                else if (Card3.Enabled && e.KeyChar.ToString().Equals(Card3.Text))
                    Card3_Click(null, null);
                else if (Card4.Enabled && e.KeyChar.ToString().Equals(Card4.Text))
                    Card4_Click(null, null);
            }

            if (e.KeyChar == '+')
                op1_Click(null, null);

            if (e.KeyChar == '-')
                op2_Click(null, null);

            if (e.KeyChar == '*')
                op3_Click(null, null);

            if (e.KeyChar == '/')
                op4_Click(null, null);

            if (e.KeyChar == '(')
                opb_Click(null, null);

            if (e.KeyChar == ')')
                clb_Click(null, null);

            if (e.KeyChar == (char)13)
            {
                if (btnEvaluate.Enabled == true)
                    btnEvalute_Click(null, null);
            }
            else { }

            if (btnEvaluate.Enabled == true)
                btnEvaluate.Focus();
        }

    

    


    }
}
