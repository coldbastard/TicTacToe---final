﻿namespace TicTacToe
{
    partial class MainMenu
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
            this.btnSP = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnPvP = new System.Windows.Forms.Button();
            this.btnSP_PM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(12, 12);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(205, 23);
            this.btnSP.TabIndex = 0;
            this.btnSP.Text = "Gra z komputerem (bez podpowiedzi)";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 128);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(12, 99);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(205, 23);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "O grze";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnPvP
            // 
            this.btnPvP.Location = new System.Drawing.Point(12, 70);
            this.btnPvP.Name = "btnPvP";
            this.btnPvP.Size = new System.Drawing.Size(205, 23);
            this.btnPvP.TabIndex = 5;
            this.btnPvP.Text = "Dwuch graczy";
            this.btnPvP.UseVisualStyleBackColor = true;
            this.btnPvP.Click += new System.EventHandler(this.btnPvP_Click);
            // 
            // btnSP_PM
            // 
            this.btnSP_PM.BackColor = System.Drawing.SystemColors.Control;
            this.btnSP_PM.Location = new System.Drawing.Point(12, 41);
            this.btnSP_PM.Name = "btnSP_PM";
            this.btnSP_PM.Size = new System.Drawing.Size(205, 23);
            this.btnSP_PM.TabIndex = 6;
            this.btnSP_PM.Text = "Gra z komputerem (z podpowiedziami)";
            this.btnSP_PM.UseVisualStyleBackColor = false;
            this.btnSP_PM.Click += new System.EventHandler(this.btnSP_PM_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 164);
            this.Controls.Add(this.btnSP_PM);
            this.Controls.Add(this.btnPvP);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSP);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.Text = "Menu główne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnPvP;
        private System.Windows.Forms.Button btnSP_PM;
    }
}