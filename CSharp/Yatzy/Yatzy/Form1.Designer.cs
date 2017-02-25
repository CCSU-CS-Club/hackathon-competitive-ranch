namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rollBox = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.diceOne = new System.Windows.Forms.PictureBox();
            this.diceTwo = new System.Windows.Forms.PictureBox();
            this.diceThree = new System.Windows.Forms.PictureBox();
            this.diceFour = new System.Windows.Forms.PictureBox();
            this.diceFive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rollBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFive)).BeginInit();
            this.SuspendLayout();
            // 
            // rollBox
            // 
            this.rollBox.Image = ((System.Drawing.Image)(resources.GetObject("rollBox.Image")));
            this.rollBox.Location = new System.Drawing.Point(262, 74);
            this.rollBox.Name = "rollBox";
            this.rollBox.Size = new System.Drawing.Size(637, 150);
            this.rollBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollBox.TabIndex = 0;
            this.rollBox.TabStop = false;
            this.rollBox.Visible = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(508, 230);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diceOne
            // 
            this.diceOne.Image = ((System.Drawing.Image)(resources.GetObject("diceOne.Image")));
            this.diceOne.Location = new System.Drawing.Point(268, 92);
            this.diceOne.Name = "diceOne";
            this.diceOne.Size = new System.Drawing.Size(109, 109);
            this.diceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceOne.TabIndex = 2;
            this.diceOne.TabStop = false;
            // 
            // diceTwo
            // 
            this.diceTwo.Image = ((System.Drawing.Image)(resources.GetObject("diceTwo.Image")));
            this.diceTwo.Location = new System.Drawing.Point(378, 92);
            this.diceTwo.Name = "diceTwo";
            this.diceTwo.Size = new System.Drawing.Size(109, 109);
            this.diceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceTwo.TabIndex = 3;
            this.diceTwo.TabStop = false;
            // 
            // diceThree
            // 
            this.diceThree.Image = ((System.Drawing.Image)(resources.GetObject("diceThree.Image")));
            this.diceThree.Location = new System.Drawing.Point(488, 92);
            this.diceThree.Name = "diceThree";
            this.diceThree.Size = new System.Drawing.Size(109, 109);
            this.diceThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceThree.TabIndex = 4;
            this.diceThree.TabStop = false;
            // 
            // diceFour
            // 
            this.diceFour.Image = ((System.Drawing.Image)(resources.GetObject("diceFour.Image")));
            this.diceFour.Location = new System.Drawing.Point(599, 92);
            this.diceFour.Name = "diceFour";
            this.diceFour.Size = new System.Drawing.Size(109, 109);
            this.diceFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceFour.TabIndex = 5;
            this.diceFour.TabStop = false;
            // 
            // diceFive
            // 
            this.diceFive.Image = ((System.Drawing.Image)(resources.GetObject("diceFive.Image")));
            this.diceFive.Location = new System.Drawing.Point(711, 92);
            this.diceFive.Name = "diceFive";
            this.diceFive.Size = new System.Drawing.Size(109, 109);
            this.diceFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceFive.TabIndex = 6;
            this.diceFive.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1129, 798);
            this.Controls.Add(this.diceFive);
            this.Controls.Add(this.diceFour);
            this.Controls.Add(this.diceThree);
            this.Controls.Add(this.diceTwo);
            this.Controls.Add(this.diceOne);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.rollBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rollBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rollBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox diceOne;
        private System.Windows.Forms.PictureBox diceTwo;
        private System.Windows.Forms.PictureBox diceThree;
        private System.Windows.Forms.PictureBox diceFour;
        private System.Windows.Forms.PictureBox diceFive;
    }
}

