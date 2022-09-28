
namespace noppa2player
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
            this.playerOne = new System.Windows.Forms.Label();
            this.playerTwo = new System.Windows.Forms.Label();
            this.playerWinner = new System.Windows.Forms.Label();
            this.buttonPlayerOne = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.AutoSize = true;
            this.playerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.Location = new System.Drawing.Point(161, 236);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(0, 24);
            this.playerOne.TabIndex = 0;
            // 
            // playerTwo
            // 
            this.playerTwo.AutoSize = true;
            this.playerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwo.Location = new System.Drawing.Point(465, 236);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(0, 24);
            this.playerTwo.TabIndex = 1;
            // 
            // playerWinner
            // 
            this.playerWinner.AutoSize = true;
            this.playerWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWinner.Location = new System.Drawing.Point(309, 44);
            this.playerWinner.Name = "playerWinner";
            this.playerWinner.Size = new System.Drawing.Size(20, 24);
            this.playerWinner.TabIndex = 2;
            this.playerWinner.Text = "a";
            // 
            // buttonPlayerOne
            // 
            this.buttonPlayerOne.Location = new System.Drawing.Point(283, 239);
            this.buttonPlayerOne.Name = "buttonPlayerOne";
            this.buttonPlayerOne.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayerOne.TabIndex = 3;
            this.buttonPlayerOne.Text = "Heitä!";
            this.buttonPlayerOne.UseVisualStyleBackColor = true;
            this.buttonPlayerOne.Click += new System.EventHandler(this.buttonPlayerOne_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(571, 403);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 45);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Pelaa uudestaan";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pelaaja 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pelaaja 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPlayerOne);
            this.Controls.Add(this.playerWinner);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOne;
        private System.Windows.Forms.Label playerTwo;
        private System.Windows.Forms.Label playerWinner;
        private System.Windows.Forms.Button buttonPlayerOne;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

