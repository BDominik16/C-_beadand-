﻿namespace Tic_Tac_Toe_Single
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compouter Wins:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(64, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(216, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 94);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(365, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 94);
            this.button3.TabIndex = 4;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(365, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 94);
            this.button4.TabIndex = 7;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(216, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 94);
            this.button5.TabIndex = 6;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(64, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 94);
            this.button6.TabIndex = 5;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(365, 261);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 94);
            this.button7.TabIndex = 10;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(216, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 94);
            this.button8.TabIndex = 9;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(64, 261);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 94);
            this.button9.TabIndex = 8;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Black;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(216, 376);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 49);
            this.button10.TabIndex = 11;
            this.button10.Text = "Restart Game";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.RestartGame);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe Single";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPUTimer;
    }
}