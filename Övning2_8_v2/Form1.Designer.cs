namespace Övning2_8_v2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMängd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxVarutyp = new System.Windows.Forms.GroupBox();
            this.rbnLösvikt = new System.Windows.Forms.RadioButton();
            this.rbnStycksak = new System.Windows.Forms.RadioButton();
            this.lbxVara = new System.Windows.Forms.ListBox();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLägg = new System.Windows.Forms.Button();
            this.gbxLägg = new System.Windows.Forms.GroupBox();
            this.btnSorteraPris = new System.Windows.Forms.Button();
            this.gbxVarutyp.SuspendLayout();
            this.gbxLägg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vara";
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(87, 16);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 20);
            this.tbxVara.TabIndex = 1;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(87, 54);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pris";
            // 
            // tbxMängd
            // 
            this.tbxMängd.Location = new System.Drawing.Point(87, 103);
            this.tbxMängd.Name = "tbxMängd";
            this.tbxMängd.Size = new System.Drawing.Size(100, 20);
            this.tbxMängd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mängd";
            // 
            // gbxVarutyp
            // 
            this.gbxVarutyp.Controls.Add(this.rbnStycksak);
            this.gbxVarutyp.Controls.Add(this.rbnLösvikt);
            this.gbxVarutyp.Location = new System.Drawing.Point(112, 186);
            this.gbxVarutyp.Name = "gbxVarutyp";
            this.gbxVarutyp.Size = new System.Drawing.Size(100, 77);
            this.gbxVarutyp.TabIndex = 6;
            this.gbxVarutyp.TabStop = false;
            this.gbxVarutyp.Text = "Varutyp";
            // 
            // rbnLösvikt
            // 
            this.rbnLösvikt.AutoSize = true;
            this.rbnLösvikt.Location = new System.Drawing.Point(6, 19);
            this.rbnLösvikt.Name = "rbnLösvikt";
            this.rbnLösvikt.Size = new System.Drawing.Size(59, 17);
            this.rbnLösvikt.TabIndex = 0;
            this.rbnLösvikt.TabStop = true;
            this.rbnLösvikt.Text = "Lösvikt";
            this.rbnLösvikt.UseVisualStyleBackColor = true;
            // 
            // rbnStycksak
            // 
            this.rbnStycksak.AutoSize = true;
            this.rbnStycksak.Location = new System.Drawing.Point(6, 42);
            this.rbnStycksak.Name = "rbnStycksak";
            this.rbnStycksak.Size = new System.Drawing.Size(69, 17);
            this.rbnStycksak.TabIndex = 1;
            this.rbnStycksak.TabStop = true;
            this.rbnStycksak.Text = "Stycksak";
            this.rbnStycksak.UseVisualStyleBackColor = true;
            // 
            // lbxVara
            // 
            this.lbxVara.FormattingEnabled = true;
            this.lbxVara.Location = new System.Drawing.Point(325, 33);
            this.lbxVara.Name = "lbxVara";
            this.lbxVara.Size = new System.Drawing.Size(264, 225);
            this.lbxVara.TabIndex = 7;
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(393, 264);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 20);
            this.tbxSumma.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Summa (kr)";
            // 
            // btnLägg
            // 
            this.btnLägg.Location = new System.Drawing.Point(42, 260);
            this.btnLägg.Name = "btnLägg";
            this.btnLägg.Size = new System.Drawing.Size(75, 23);
            this.btnLägg.TabIndex = 10;
            this.btnLägg.Text = "Lägg till";
            this.btnLägg.UseVisualStyleBackColor = true;
            this.btnLägg.Click += new System.EventHandler(this.btnLägg_Click);
            // 
            // gbxLägg
            // 
            this.gbxLägg.Controls.Add(this.label1);
            this.gbxLägg.Controls.Add(this.tbxVara);
            this.gbxLägg.Controls.Add(this.label2);
            this.gbxLägg.Controls.Add(this.tbxPris);
            this.gbxLägg.Controls.Add(this.label3);
            this.gbxLägg.Controls.Add(this.tbxMängd);
            this.gbxLägg.Location = new System.Drawing.Point(12, 33);
            this.gbxLägg.Name = "gbxLägg";
            this.gbxLägg.Size = new System.Drawing.Size(200, 147);
            this.gbxLägg.TabIndex = 11;
            this.gbxLägg.TabStop = false;
            this.gbxLägg.Text = "Lägg till";
            // 
            // btnSorteraPris
            // 
            this.btnSorteraPris.Location = new System.Drawing.Point(42, 302);
            this.btnSorteraPris.Name = "btnSorteraPris";
            this.btnSorteraPris.Size = new System.Drawing.Size(75, 23);
            this.btnSorteraPris.TabIndex = 12;
            this.btnSorteraPris.Text = "Sortera pris";
            this.btnSorteraPris.UseVisualStyleBackColor = true;
            this.btnSorteraPris.Click += new System.EventHandler(this.btnSorteraPris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSorteraPris);
            this.Controls.Add(this.gbxLägg);
            this.Controls.Add(this.btnLägg);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxVara);
            this.Controls.Add(this.gbxVarutyp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxVarutyp.ResumeLayout(false);
            this.gbxVarutyp.PerformLayout();
            this.gbxLägg.ResumeLayout(false);
            this.gbxLägg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMängd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxVarutyp;
        private System.Windows.Forms.RadioButton rbnStycksak;
        private System.Windows.Forms.RadioButton rbnLösvikt;
        private System.Windows.Forms.ListBox lbxVara;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLägg;
        private System.Windows.Forms.GroupBox gbxLägg;
        private System.Windows.Forms.Button btnSorteraPris;
    }
}

