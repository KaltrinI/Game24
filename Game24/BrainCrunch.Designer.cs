namespace Game24
{
    partial class BrainCrunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrainCrunch));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customLabel1 = new CustomLabel.CustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 29);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Enabled = false;
            this.btnEvaluate.Location = new System.Drawing.Point(261, 268);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(120, 34);
            this.btnEvaluate.TabIndex = 39;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvalute_Click);
            // 
            // Card3
            // 
            this.Card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card3.BackgroundImage")));
            this.Card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card3.ForeColor = System.Drawing.Color.White;
            this.Card3.Location = new System.Drawing.Point(12, 168);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(89, 134);
            this.Card3.TabIndex = 29;
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
            this.Card4.Location = new System.Drawing.Point(141, 168);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(89, 134);
            this.Card4.TabIndex = 30;
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
            this.Card1.Location = new System.Drawing.Point(12, 12);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(89, 134);
            this.Card1.TabIndex = 0;
            this.Card1.Text = " ";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.SystemColors.Control;
            this.Card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card2.BackgroundImage")));
            this.Card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Card2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card2.ForeColor = System.Drawing.Color.White;
            this.Card2.Location = new System.Drawing.Point(141, 12);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(89, 134);
            this.Card2.TabIndex = 3;
            this.Card2.Text = " ";
            this.Card2.UseVisualStyleBackColor = false;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.Transparent;
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.Location = new System.Drawing.Point(325, 168);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(57, 54);
            this.clb.TabIndex = 36;
            this.clb.Text = ")";
            this.clb.UseVisualStyleBackColor = false;
            this.clb.Click += new System.EventHandler(this.clb_Click);
            // 
            // opb
            // 
            this.opb.BackColor = System.Drawing.Color.Transparent;
            this.opb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opb.Location = new System.Drawing.Point(262, 168);
            this.opb.Name = "opb";
            this.opb.Size = new System.Drawing.Size(57, 54);
            this.opb.TabIndex = 35;
            this.opb.Text = "(";
            this.opb.UseVisualStyleBackColor = false;
            this.opb.Click += new System.EventHandler(this.opb_Click);
            // 
            // op4
            // 
            this.op4.BackColor = System.Drawing.Color.Transparent;
            this.op4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4.Location = new System.Drawing.Point(325, 92);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(57, 54);
            this.op4.TabIndex = 34;
            this.op4.Text = "/";
            this.op4.UseVisualStyleBackColor = false;
            this.op4.Click += new System.EventHandler(this.op4_Click);
            // 
            // op3
            // 
            this.op3.BackColor = System.Drawing.SystemColors.Control;
            this.op3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.Location = new System.Drawing.Point(262, 92);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(57, 54);
            this.op3.TabIndex = 33;
            this.op3.Text = "*";
            this.op3.UseVisualStyleBackColor = false;
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // op2
            // 
            this.op2.BackColor = System.Drawing.Color.Transparent;
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.Location = new System.Drawing.Point(325, 12);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(57, 54);
            this.op2.TabIndex = 32;
            this.op2.Text = "-";
            this.op2.UseVisualStyleBackColor = false;
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // op1
            // 
            this.op1.BackColor = System.Drawing.Color.Transparent;
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.Location = new System.Drawing.Point(262, 12);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(57, 54);
            this.op1.TabIndex = 31;
            this.op1.Text = "+";
            this.op1.UseVisualStyleBackColor = false;
            this.op1.Click += new System.EventHandler(this.op1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 335);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(83, 20);
            this.customLabel1.TabIndex = 44;
            this.customLabel1.Text = "Expresion:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Expression:";
            // 
            // BrainCrunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(401, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEvaluate);
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
            this.Name = "BrainCrunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game24";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrainCrunch_FormClosed);
            this.Load += new System.EventHandler(this.BestOf_Load);
            this.Shown += new System.EventHandler(this.BestOf_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BestOf_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEvaluate;
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
        private System.Windows.Forms.Timer timer1;
        private CustomLabel.CustomLabel customLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}