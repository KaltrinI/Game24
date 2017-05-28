using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Game24
{
    public partial class BrainCrunch : Form
    {
        string Name;
        static double vreme;
        static int count;
        static int correct;
        bool flag ;
        BCHighForm bc;
        Game24 game;
        DataTable dt;

        public BrainCrunch(string n)
        {
            InitializeComponent();
            bc = new BCHighForm();
            Name = n;
        }

        private void BestOf_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            flag = true;
            vreme = 0;
            count = 0;
            correct = 0;
            game = new Game24();
            dt = new DataTable();
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


        private void checkEnable()
        {
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
            flag = true;
            game.Generate();
            Card1.Text = game.Card1.ToString();
            Card2.Text = game.Card2.ToString();
            Card3.Text = game.Card3.ToString();
            Card4.Text = game.Card4.ToString();
            count++;
            label6.Text = count.ToString();
            reset();

        }



        private void btnEvalute_Click(object sender, EventArgs e)
        {
            
            try
            {
                var v = dt.Compute(label2.Text, "");

                if (v.ToString() == "24")
                {
                    correct++;
                    label4.Text = correct.ToString();
                    if (correct == 5) {
                        timer1.Stop();

                         MessageBox.Show(String.Format("Your time for completing 5 puzzles is {0:0.000} seconds", vreme / 60.0));
                        
                        if(bc.scene.lista.Count<10)
                            bc.ElemAdd(new BCHigh(Name, (vreme/60.0)));

                        else if (vreme.ToString().CompareTo(bc.scene.worst().time) == -1) {
                            bc.ElemAdd(new BCHigh(Name, (vreme/60.0)));
                            
                        }

                        bc.ShowDialog();
                        Close();
                    
                    }
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

        private void reset() {

            label2.Text = "";
            Card2.Enabled = true;
            Card1.Enabled = true;
            Card3.Enabled = true;
            Card4.Enabled = true;
            btnEvaluate.Enabled = false;
            flag = true;
        
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            vreme += 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void BestOf_KeyPress(object sender, KeyPressEventArgs e)
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

            if (btnEvaluate.Enabled == true)
                btnEvaluate.Focus();

        }

        private void BestOf_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("How fast can you solve 5 random puzzles?\nTime begins as soon as you close this dialog box");
            Generate();
            timer1.Enabled = true;
        }

        private void BrainCrunch_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Dispose();
        }

    }
}
