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
    public partial class TimeAttack : Form
    {
        TAHighForm ta;
        Game24 game;
        static int count;
        static int correct;
        bool flag;
        string name;
        DataTable dt;

        public TimeAttack(string n)
        {
            InitializeComponent();
            name = n;
            dt = new DataTable();
            ta = new TAHighForm();
        }

        private void TimeAttack_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            game = new Game24();
            flag = true;
            count = 0;
            correct = 0;
            prb_Vreme.Text = "3:00";
        }

        


        private void Card1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card1.Text;
                Card1.Enabled = false;
                flag = false;
                checkEnable();
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card2.Text;
                Card2.Enabled = false;
                flag = false;
                checkEnable();
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card3.Text;
                Card3.Enabled = false;
                flag = false;
                checkEnable();
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                label2.Text += Card4.Text;
                Card4.Enabled = false;
                flag = false;
                checkEnable();
            }
        }


        private void checkEnable() {
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
            if(!flag)
            label2.Text += clb.Text;

        }

        private void Generate()
        {
            game.Generate();
            Card1.Text = game.Card1.ToString();
            Card2.Text = game.Card2.ToString();
            Card3.Text = game.Card3.ToString();
            Card4.Text = game.Card4.ToString();
            count++;
            label6.Text = count.ToString();
            reset();

        }

        private void reset() {
            Card1.Enabled = true;
            Card2.Enabled = true;
            Card3.Enabled = true;
            Card4.Enabled = true;
            label2.Text = "";
            btnEvaluate.Enabled = false;
            flag = true;
        
        }

        private void btnEvalute_Click(object sender, EventArgs e)
        {
            flag = true;

            try
            {
                var v = dt.Compute(label2.Text, "");

                if (v.ToString() == "24")
                {
                    correct++;
                    label4.Text = correct.ToString();
                    Generate();
                }
                else
                {
                    reset();
                }
            }
            catch
            {
                reset();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prb_Vreme.Text = String.Format("{0}:{1:00}", (prb_Vreme.Value - 1) / 60, (prb_Vreme.Value - 1) % 60);
            prb_Vreme.PerformStep();
            
            if (prb_Vreme.Text.Equals("0:00"))
            {
                timer1.Enabled = false;
                ta.ElemAdd(new TAHigh(name, correct));
                MessageBox.Show("You answered " + correct + " puzzles");
                ta.ShowDialog();
                Close();
            
            }
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        

        private void TimeAttack_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Dispose();
        }

        private void TimeAttack_KeyPress(object sender, KeyPressEventArgs e)
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
                if(btnEvaluate.Enabled==true)
                btnEvalute_Click(null, null);
            }

            if (btnEvaluate.Enabled == true)
                btnEvaluate.Focus();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Generate();
            btnClear.Focus();
        }

        private void TimeAttack_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Time starts when you close this window.\nYou have 3 minutes to solve as much puzzles as you can.\n");
            Generate();
            timer1.Enabled = true;

        }

     

    }
}
