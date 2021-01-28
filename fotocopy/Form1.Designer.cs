namespace fotocopy
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonVyberZdroje1 = new System.Windows.Forms.Button();
            this.textBoxZdroj1 = new System.Windows.Forms.TextBox();
            this.textBoxCilJpg = new System.Windows.Forms.TextBox();
            this.textBoxCilRaw = new System.Windows.Forms.TextBox();
            this.buttonVyberCileJpg = new System.Windows.Forms.Button();
            this.buttonVyberCileRaw = new System.Windows.Forms.Button();
            this.listViewSouboryZdrojove = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNacti = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMeziadresar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelExt = new System.Windows.Forms.Label();
            this.textBoxMaska = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPriklad = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonVyberCileVideo = new System.Windows.Forms.Button();
            this.textBoxCilVideo = new System.Windows.Forms.TextBox();
            this.backgroundWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.labelKopirovanySoubor = new System.Windows.Forms.Label();
            this.backgroundWorkerDelete = new System.ComponentModel.BackgroundWorker();
            this.textBoxZdroj2 = new System.Windows.Forms.TextBox();
            this.buttonVyberZdroje2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVyberZdroje1
            // 
            this.buttonVyberZdroje1.Location = new System.Drawing.Point(310, 54);
            this.buttonVyberZdroje1.Name = "buttonVyberZdroje1";
            this.buttonVyberZdroje1.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberZdroje1.TabIndex = 0;
            this.buttonVyberZdroje1.Text = "...";
            this.buttonVyberZdroje1.UseVisualStyleBackColor = true;
            this.buttonVyberZdroje1.Click += new System.EventHandler(this.buttonVyberZdroje1_Click);
            // 
            // textBoxZdroj1
            // 
            this.textBoxZdroj1.AllowDrop = true;
            this.textBoxZdroj1.Location = new System.Drawing.Point(12, 57);
            this.textBoxZdroj1.Name = "textBoxZdroj1";
            this.textBoxZdroj1.Size = new System.Drawing.Size(292, 20);
            this.textBoxZdroj1.TabIndex = 2;
            this.textBoxZdroj1.TextChanged += new System.EventHandler(this.textBoxZdroj_TextChanged);
            this.textBoxZdroj1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj_DragDrop);
            this.textBoxZdroj1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj_DragEnter);
            // 
            // textBoxCilJpg
            // 
            this.textBoxCilJpg.AllowDrop = true;
            this.textBoxCilJpg.Location = new System.Drawing.Point(12, 229);
            this.textBoxCilJpg.Name = "textBoxCilJpg";
            this.textBoxCilJpg.Size = new System.Drawing.Size(292, 20);
            this.textBoxCilJpg.TabIndex = 3;
            this.textBoxCilJpg.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxCil1_DragDrop);
            this.textBoxCilJpg.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxCil1_DragEnter);
            // 
            // textBoxCilRaw
            // 
            this.textBoxCilRaw.AllowDrop = true;
            this.textBoxCilRaw.Location = new System.Drawing.Point(12, 310);
            this.textBoxCilRaw.Name = "textBoxCilRaw";
            this.textBoxCilRaw.Size = new System.Drawing.Size(292, 20);
            this.textBoxCilRaw.TabIndex = 4;
            this.textBoxCilRaw.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxCil2_DragDrop);
            this.textBoxCilRaw.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxCil2_DragEnter);
            // 
            // buttonVyberCileJpg
            // 
            this.buttonVyberCileJpg.Location = new System.Drawing.Point(310, 227);
            this.buttonVyberCileJpg.Name = "buttonVyberCileJpg";
            this.buttonVyberCileJpg.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberCileJpg.TabIndex = 5;
            this.buttonVyberCileJpg.Text = "...";
            this.buttonVyberCileJpg.UseVisualStyleBackColor = true;
            this.buttonVyberCileJpg.Click += new System.EventHandler(this.buttonVyberCileJpg_Click);
            // 
            // buttonVyberCileRaw
            // 
            this.buttonVyberCileRaw.Location = new System.Drawing.Point(310, 307);
            this.buttonVyberCileRaw.Name = "buttonVyberCileRaw";
            this.buttonVyberCileRaw.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberCileRaw.TabIndex = 6;
            this.buttonVyberCileRaw.Text = "...";
            this.buttonVyberCileRaw.UseVisualStyleBackColor = true;
            this.buttonVyberCileRaw.Click += new System.EventHandler(this.buttonVyberCileRaw_Click);
            // 
            // listViewSouboryZdrojove
            // 
            this.listViewSouboryZdrojove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewSouboryZdrojove.GridLines = true;
            this.listViewSouboryZdrojove.HideSelection = false;
            this.listViewSouboryZdrojove.Location = new System.Drawing.Point(362, 41);
            this.listViewSouboryZdrojove.Name = "listViewSouboryZdrojove";
            this.listViewSouboryZdrojove.Size = new System.Drawing.Size(384, 149);
            this.listViewSouboryZdrojove.TabIndex = 7;
            this.listViewSouboryZdrojove.UseCompatibleStateImageBehavior = false;
            this.listViewSouboryZdrojove.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 86;
            // 
            // buttonNacti
            // 
            this.buttonNacti.Location = new System.Drawing.Point(12, 401);
            this.buttonNacti.Name = "buttonNacti";
            this.buttonNacti.Size = new System.Drawing.Size(75, 23);
            this.buttonNacti.TabIndex = 8;
            this.buttonNacti.Text = "Načti zdroj";
            this.buttonNacti.UseVisualStyleBackColor = true;
            this.buttonNacti.Click += new System.EventHandler(this.buttonNacti_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(93, 401);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(124, 23);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Zkopíruj";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(223, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Smaž zdroj";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "*.jpg *.avi *.mov *.cr2 *.mp4 *.mts kopírovat z adresářě:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "*.jpg kopírovat do:";
            // 
            // textBoxMeziadresar
            // 
            this.textBoxMeziadresar.Location = new System.Drawing.Point(362, 248);
            this.textBoxMeziadresar.Name = "textBoxMeziadresar";
            this.textBoxMeziadresar.Size = new System.Drawing.Size(171, 20);
            this.textBoxMeziadresar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "*.cr2 nebo *.arw kopírovat do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "další meziadresář (nemusí být)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "/";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 459);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(674, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "ZDROJ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(15, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "CÍL";
            // 
            // labelExt
            // 
            this.labelExt.AutoSize = true;
            this.labelExt.Location = new System.Drawing.Point(15, 443);
            this.labelExt.Name = "labelExt";
            this.labelExt.Size = new System.Drawing.Size(33, 13);
            this.labelExt.TabIndex = 25;
            this.labelExt.Text = "co se";
            // 
            // textBoxMaska
            // 
            this.textBoxMaska.Location = new System.Drawing.Point(569, 251);
            this.textBoxMaska.Name = "textBoxMaska";
            this.textBoxMaska.Size = new System.Drawing.Size(82, 20);
            this.textBoxMaska.TabIndex = 26;
            this.textBoxMaska.TextChanged += new System.EventHandler(this.textBoxMaska_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "název podadresáře";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "y - rok";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "M - měsíc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(569, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "d - den";
            // 
            // labelPriklad
            // 
            this.labelPriklad.AutoSize = true;
            this.labelPriklad.Location = new System.Drawing.Point(607, 325);
            this.labelPriklad.Name = "labelPriklad";
            this.labelPriklad.Size = new System.Drawing.Size(41, 13);
            this.labelPriklad.TabIndex = 31;
            this.labelPriklad.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(569, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "např.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "*.avi *.mov *.mp4 *.mts kopírovat do:";
            // 
            // buttonVyberCileVideo
            // 
            this.buttonVyberCileVideo.Location = new System.Drawing.Point(310, 269);
            this.buttonVyberCileVideo.Name = "buttonVyberCileVideo";
            this.buttonVyberCileVideo.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberCileVideo.TabIndex = 34;
            this.buttonVyberCileVideo.Text = "...";
            this.buttonVyberCileVideo.UseVisualStyleBackColor = true;
            this.buttonVyberCileVideo.Click += new System.EventHandler(this.buttonVyberCileVideo_Click);
            // 
            // textBoxCilVideo
            // 
            this.textBoxCilVideo.AllowDrop = true;
            this.textBoxCilVideo.Location = new System.Drawing.Point(12, 271);
            this.textBoxCilVideo.Name = "textBoxCilVideo";
            this.textBoxCilVideo.Size = new System.Drawing.Size(292, 20);
            this.textBoxCilVideo.TabIndex = 33;
            this.textBoxCilVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxCilVideo_DragDrop);
            this.textBoxCilVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxCilVideo_DragEnter);
            // 
            // backgroundWorkerCopy
            // 
            this.backgroundWorkerCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCopy_DoWork);
            // 
            // labelKopirovanySoubor
            // 
            this.labelKopirovanySoubor.AutoSize = true;
            this.labelKopirovanySoubor.Location = new System.Drawing.Point(54, 443);
            this.labelKopirovanySoubor.Name = "labelKopirovanySoubor";
            this.labelKopirovanySoubor.Size = new System.Drawing.Size(0, 13);
            this.labelKopirovanySoubor.TabIndex = 37;
            // 
            // backgroundWorkerDelete
            // 
            this.backgroundWorkerDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDelete_DoWork);
            // 
            // textBoxZdroj2
            // 
            this.textBoxZdroj2.AllowDrop = true;
            this.textBoxZdroj2.Location = new System.Drawing.Point(12, 84);
            this.textBoxZdroj2.Name = "textBoxZdroj2";
            this.textBoxZdroj2.Size = new System.Drawing.Size(292, 20);
            this.textBoxZdroj2.TabIndex = 38;
            this.textBoxZdroj2.TextChanged += new System.EventHandler(this.textBoxZdroj2_TextChanged);
            this.textBoxZdroj2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj2_DragDrop);
            this.textBoxZdroj2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj2_DragEnter);
            // 
            // buttonVyberZdroje2
            // 
            this.buttonVyberZdroje2.Location = new System.Drawing.Point(310, 81);
            this.buttonVyberZdroje2.Name = "buttonVyberZdroje2";
            this.buttonVyberZdroje2.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberZdroje2.TabIndex = 39;
            this.buttonVyberZdroje2.Text = "...";
            this.buttonVyberZdroje2.UseVisualStyleBackColor = true;
            this.buttonVyberZdroje2.Click += new System.EventHandler(this.buttonVyberZdroje2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 501);
            this.Controls.Add(this.buttonVyberZdroje2);
            this.Controls.Add(this.textBoxZdroj2);
            this.Controls.Add(this.labelKopirovanySoubor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonVyberCileVideo);
            this.Controls.Add(this.textBoxCilVideo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelPriklad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMaska);
            this.Controls.Add(this.labelExt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMeziadresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonNacti);
            this.Controls.Add(this.listViewSouboryZdrojove);
            this.Controls.Add(this.buttonVyberCileRaw);
            this.Controls.Add(this.buttonVyberCileJpg);
            this.Controls.Add(this.textBoxCilRaw);
            this.Controls.Add(this.textBoxCilJpg);
            this.Controls.Add(this.textBoxZdroj1);
            this.Controls.Add(this.buttonVyberZdroje1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fotocopy";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonVyberZdroje1;
        private System.Windows.Forms.TextBox textBoxZdroj1;
        private System.Windows.Forms.TextBox textBoxCilJpg;
        private System.Windows.Forms.TextBox textBoxCilRaw;
        private System.Windows.Forms.Button buttonVyberCileJpg;
        private System.Windows.Forms.Button buttonVyberCileRaw;
        private System.Windows.Forms.ListView listViewSouboryZdrojove;
        private System.Windows.Forms.Button buttonNacti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMeziadresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelExt;
        private System.Windows.Forms.TextBox textBoxMaska;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPriklad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonVyberCileVideo;
        private System.Windows.Forms.TextBox textBoxCilVideo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCopy;
        private System.Windows.Forms.Label labelKopirovanySoubor;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDelete;
        private System.Windows.Forms.TextBox textBoxZdroj2;
        private System.Windows.Forms.Button buttonVyberZdroje2;
    }
}

