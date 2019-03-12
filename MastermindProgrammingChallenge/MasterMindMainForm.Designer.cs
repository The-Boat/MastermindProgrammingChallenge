﻿namespace MastermindProgrammingChallenge
{
    partial class MasterMindMainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colourButton4 = new System.Windows.Forms.Button();
            this.colourButton3 = new System.Windows.Forms.Button();
            this.colourButton2 = new System.Windows.Forms.Button();
            this.colourButton1 = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colourButton4);
            this.groupBox1.Controls.Add(this.colourButton3);
            this.groupBox1.Controls.Add(this.colourButton2);
            this.groupBox1.Controls.Add(this.colourButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guess";
            // 
            // colourButton4
            // 
            this.colourButton4.Location = new System.Drawing.Point(444, 76);
            this.colourButton4.Name = "colourButton4";
            this.colourButton4.Size = new System.Drawing.Size(140, 155);
            this.colourButton4.TabIndex = 3;
            this.colourButton4.Text = "colourButton4";
            this.colourButton4.UseVisualStyleBackColor = true;
            // 
            // colourButton3
            // 
            this.colourButton3.Location = new System.Drawing.Point(298, 76);
            this.colourButton3.Name = "colourButton3";
            this.colourButton3.Size = new System.Drawing.Size(140, 155);
            this.colourButton3.TabIndex = 2;
            this.colourButton3.Text = "colourButton3";
            this.colourButton3.UseVisualStyleBackColor = true;
            // 
            // colourButton2
            // 
            this.colourButton2.Location = new System.Drawing.Point(152, 76);
            this.colourButton2.Name = "colourButton2";
            this.colourButton2.Size = new System.Drawing.Size(140, 155);
            this.colourButton2.TabIndex = 1;
            this.colourButton2.Text = "colourButton2";
            this.colourButton2.UseVisualStyleBackColor = true;
            // 
            // colourButton1
            // 
            this.colourButton1.Location = new System.Drawing.Point(6, 76);
            this.colourButton1.Name = "colourButton1";
            this.colourButton1.Size = new System.Drawing.Size(140, 155);
            this.colourButton1.TabIndex = 0;
            this.colourButton1.Text = "colourButton1";
            this.colourButton1.UseVisualStyleBackColor = true;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(426, 386);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(172, 37);
            this.lblGuess.TabIndex = 1;
            this.lblGuess.Text = "Guess : [0]";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPlayer.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(133, 37);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player : ";
            // 
            // lblHits
            // 
            this.lblHits.AutoSize = true;
            this.lblHits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHits.Location = new System.Drawing.Point(463, 440);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(135, 37);
            this.lblHits.TabIndex = 3;
            this.lblHits.Text = "Hits : [0]";
            // 
            // MasterMindMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 513);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.groupBox1);
            this.Name = "MasterMindMainForm";
            this.Text = "Mastermind";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button colourButton4;
        private System.Windows.Forms.Button colourButton3;
        private System.Windows.Forms.Button colourButton2;
        private System.Windows.Forms.Button colourButton1;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblHits;
    }
}

