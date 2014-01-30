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
            this.buttonVyberZroje = new System.Windows.Forms.Button();
            this.textBoxZdroj = new System.Windows.Forms.TextBox();
            this.textBoxCilJpg = new System.Windows.Forms.TextBox();
            this.textBoxCilRaw = new System.Windows.Forms.TextBox();
            this.buttonVyberCileJpg = new System.Windows.Forms.Button();
            this.buttonVyberCileRaw = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
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
            this.checkBoxVynechtJpg = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.labelKopirovanySoubor = new System.Windows.Forms.Label();
            this.backgroundWorkerDelete = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonVyberZroje
            // 
            this.buttonVyberZroje.Location = new System.Drawing.Point(310, 54);
            this.buttonVyberZroje.Name = "buttonVyberZroje";
            this.buttonVyberZroje.Size = new System.Drawing.Size(29, 23);
            this.buttonVyberZroje.TabIndex = 0;
            this.buttonVyberZroje.Text = "...";
            this.buttonVyberZroje.UseVisualStyleBackColor = true;
            this.buttonVyberZroje.Click += new System.EventHandler(this.buttonVyberZdroje_Click);
            // 
            // textBoxZdroj
            // 
            this.textBoxZdroj.AllowDrop = true;
            this.textBoxZdroj.Location = new System.Drawing.Point(12, 57);
            this.textBoxZdroj.Name = "textBoxZdroj";
            this.textBoxZdroj.Size = new System.Drawing.Size(292, 20);
            this.textBoxZdroj.TabIndex = 2;
            this.textBoxZdroj.TextChanged += new System.EventHandler(this.textBoxZdroj_TextChanged);
            this.textBoxZdroj.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj_DragDrop);
            this.textBoxZdroj.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxZdroj_DragEnter);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(362, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 149);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.buttonNacti.Text = "Načti odkud";
            this.buttonNacti.UseVisualStyleBackColor = true;
            this.buttonNacti.Click += new System.EventHandler(this.buttonNacti_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(93, 401);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(124, 23);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Zkopíruj odkud kam";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(223, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(81, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Smaž odkud";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "*.jpg *.avi *.mov *.cr2 *.mp4 kopírovat odsud (např. karta)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "*.jpg kopírovat sem";
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
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "*.cr2 kopírovat sem";
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
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "ODKUD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(15, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "KAM";
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
            this.label14.Size = new System.Drawing.Size(159, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "*.avi *.mov *.mp4 kopírovat sem";
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
            // 
            // checkBoxVynechtJpg
            // 
            this.checkBoxVynechtJpg.AutoSize = true;
            this.checkBoxVynechtJpg.Checked = true;
            this.checkBoxVynechtJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVynechtJpg.Location = new System.Drawing.Point(12, 350);
            this.checkBoxVynechtJpg.Name = "checkBoxVynechtJpg";
            this.checkBoxVynechtJpg.Size = new System.Drawing.Size(120, 17);
            this.checkBoxVynechtJpg.TabIndex = 36;
            this.checkBoxVynechtJpg.Text = "Vynechat jpg k mov";
            this.checkBoxVynechtJpg.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 501);
            this.Controls.Add(this.labelKopirovanySoubor);
            this.Controls.Add(this.checkBoxVynechtJpg);
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
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonVyberCileRaw);
            this.Controls.Add(this.buttonVyberCileJpg);
            this.Controls.Add(this.textBoxCilRaw);
            this.Controls.Add(this.textBoxCilJpg);
            this.Controls.Add(this.textBoxZdroj);
            this.Controls.Add(this.buttonVyberZroje);
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
        private System.Windows.Forms.Button buttonVyberZroje;
        private System.Windows.Forms.TextBox textBoxZdroj;
        private System.Windows.Forms.TextBox textBoxCilJpg;
        private System.Windows.Forms.TextBox textBoxCilRaw;
        private System.Windows.Forms.Button buttonVyberCileJpg;
        private System.Windows.Forms.Button buttonVyberCileRaw;
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.CheckBox checkBoxVynechtJpg;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCopy;
        private System.Windows.Forms.Label labelKopirovanySoubor;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDelete;
    }
}

