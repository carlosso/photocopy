﻿
namespace fotocopy
{
    partial class FormNastaveni
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
            this.textBoxTypySouboruFotek = new System.Windows.Forms.TextBox();
            this.textBoxTypySouboruRaw = new System.Windows.Forms.TextBox();
            this.textBoxTypySouboruVideo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTypySouboruFotek
            // 
            this.textBoxTypySouboruFotek.Location = new System.Drawing.Point(33, 38);
            this.textBoxTypySouboruFotek.Name = "textBoxTypySouboruFotek";
            this.textBoxTypySouboruFotek.Size = new System.Drawing.Size(311, 20);
            this.textBoxTypySouboruFotek.TabIndex = 0;
            // 
            // textBoxTypySouboruRaw
            // 
            this.textBoxTypySouboruRaw.Location = new System.Drawing.Point(33, 88);
            this.textBoxTypySouboruRaw.Name = "textBoxTypySouboruRaw";
            this.textBoxTypySouboruRaw.Size = new System.Drawing.Size(311, 20);
            this.textBoxTypySouboruRaw.TabIndex = 1;
            // 
            // textBoxTypySouboruVideo
            // 
            this.textBoxTypySouboruVideo.Location = new System.Drawing.Point(33, 142);
            this.textBoxTypySouboruVideo.Name = "textBoxTypySouboruVideo";
            this.textBoxTypySouboruVideo.Size = new System.Drawing.Size(311, 20);
            this.textBoxTypySouboruVideo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typy souborů fotek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Typy souborů raw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Typy souborů video";
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(137, 204);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(75, 23);
            this.buttonUlozit.TabIndex = 6;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // FormNastaveni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 271);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTypySouboruVideo);
            this.Controls.Add(this.textBoxTypySouboruRaw);
            this.Controls.Add(this.textBoxTypySouboruFotek);
            this.Name = "FormNastaveni";
            this.Text = "Nastavení";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTypySouboruFotek;
        private System.Windows.Forms.TextBox textBoxTypySouboruRaw;
        private System.Windows.Forms.TextBox textBoxTypySouboruVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUlozit;
    }
}