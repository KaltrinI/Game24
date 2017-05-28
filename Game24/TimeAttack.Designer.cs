namespace Game24
{
    partial class TimeAttack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeAttack));
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.clb = new System.Windows.Forms.Button();
            this.opb = new System.Windows.Forms.Button();
            this.op4 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.Button();
            this.op2 = new System.Windows.Forms.Button();
            this.op1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.prb_Vreme = new ProgressBarWithText.ProgressBarWithText();
            this.SuspendLayout();
            // 
            // Card3
            // 
            this.Card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card3.BackgroundImage")));
            this.Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card3.ForeColor = System.Drawing.Color.White;
            this.Card3.Location = new System.Drawing.Point(12, 177);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(89, 134);
            this.Card3.TabIndex = 12;
            this.Card3.Text = " ";
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // Card4
            // 
            this.Card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card4.BackgroundImage")));
            this.Card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card4.ForeColor = System.Drawing.Color.White;
            this.Card4.Location = new System.Drawing.Point(141, 177);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(89, 134);
            this.Card4.TabIndex = 13;
            this.Card4.Text = " ";
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // Card1
            // 
            this.Card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card1.BackgroundImage")));
            this.Card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card1.ForeColor = System.Drawing.Color.White;
            this.Card1.Location = new System.Drawing.Point(12, 21);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(89, 134);
            this.Card1.TabIndex = 11;
            this.Card1.Text = " ";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // Card2
            // 
            this.Card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card2.BackgroundImage")));
            this.Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card2.ForeColor = System.Drawing.Color.White;
            this.Card2.Location = new System.Drawing.Point(141, 21);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(89, 134);
            this.Card2.TabIndex = 10;
            this.Card2.Text = " ";
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // clb
            // 
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.Location = new System.Drawing.Point(325, 177);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(57, 54);
            this.clb.TabIndex = 19;
            this.clb.Text = ")";
            this.clb.UseVisualStyleBackColor = true;
            this.clb.Click += new System.EventHandler(this.clb_Click);
            // 
            // opb
            // 
            this.opb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opb.Location = new System.Drawing.Point(262, 177);
            this.opb.Name = "opb";
            this.opb.Size = new System.Drawing.Size(57, 54);
            this.opb.TabIndex = 18;
            this.opb.Text = "(";
            this.opb.UseVisualStyleBackColor = true;
            this.opb.Click += new System.EventHandler(this.opb_Click);
            // 
            // op4
            // 
            this.op4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4.Location = new System.Drawing.Point(325, 101);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(57, 54);
            this.op4.TabIndex = 17;
            this.op4.Text = "/";
            this.op4.UseVisualStyleBackColor = true;
            this.op4.Click += new System.EventHandler(this.op4_Click);
            // 
            // op3
            // 
            this.op3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.Location = new System.Drawing.Point(262, 101);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(57, 54);
            this.op3.TabIndex = 16;
            this.op3.Text = "*";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // op2
            // 
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.Location = new System.Drawing.Point(325, 21);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(57, 54);
            this.op2.TabIndex = 15;
            this.op2.Text = "-";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // op1
            // 
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.Location = new System.Drawing.Point(262, 21);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(57, 54);
            this.op1.TabIndex = 14;
            this.op1.Text = "+";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.op1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(107, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Expresion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 29);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Enabled = false;
            this.btnEvaluate.Location = new System.Drawing.Point(262, 314);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(120, 34);
            this.btnEvaluate.TabIndex = 22;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvalute_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 29;
            this.button1.Text = "Skip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // prb_Vreme
            // 
            this.prb_Vreme.Location = new System.Drawing.Point(12, 354);
            this.prb_Vreme.Maximum = 180;
            this.prb_Vreme.Name = "prb_Vreme";
            this.prb_Vreme.Size = new System.Drawing.Size(369, 35);
            this.prb_Vreme.Step = -1;
            this.prb_Vreme.TabIndex = 32;
            this.prb_Vreme.Value = 180;
            // 
            // TimeAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 416);
            this.Controls.Add(this.prb_Vreme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.opb);
            this.Controls.Add(this.op4);
            this.Controls.Add(this.op3);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.op1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimeAttack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game24";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeAttack_FormClosed);
            this.Load += new System.EventHandler(this.TimeAttack_Load);
            this.Shown += new System.EventHandler(this.TimeAttack_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeAttack_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button clb;
        private System.Windows.Forms.Button opb;
        private System.Windows.Forms.Button op4;
        private System.Windows.Forms.Button op3;
        private System.Windows.Forms.Button op2;
        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private ProgressBarWithText.ProgressBarWithText prb_Vreme;
    }
}