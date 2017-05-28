namespace Game24
{
    partial class HowToPlay
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "HOW TO PLAY",
            "Game24 is a card game , where 4 cards are chosen at Random",
            "and using all of them you need to write an expression that is equal to 24.",
            "Available operations are addition , subtraction , multiplication , and divison.",
            "There are 3 game types in Single Player mode:",
            "",
            "Practice Mode:",
            "You generate random numbers and try to form a valid expression with",
            "no time pressure and possibility of being shown 1 solution for the given problem",
            "",
            "Time Attack:",
            "Your job is to solve as much puzzles as you can for 3 minutes.",
            "If you do not know the answer to a puzzle you can just skip it.",
            "",
            "Brain Crunch:",
            "The goal is to solve 5 random puzzles without having an option to skip ",
            "any unknown puzzle solution. At the end your time for solving 5 puzzles is displa" +
                "yed.",
            "",
            "Multiplayer:",
            "In construction",
            "",
            "Gameplay Controls :",
            "You can either click a card , or operator and it will appear as part of the expre" +
                "ssion or ",
            "just press the key corresponding to the card number or operator.",
            "",
            "For a guidethrough watch gameplay video located on the instalation folder"});
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(434, 355);
            this.listBox1.TabIndex = 0;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 389);
            this.Controls.Add(this.listBox1);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;

    }
}