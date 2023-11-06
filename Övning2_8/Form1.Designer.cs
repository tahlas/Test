namespace Övning2_8
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
            lblVara = new Label();
            tbxVara = new TextBox();
            rbnLösvikt = new RadioButton();
            rbnStycksak = new RadioButton();
            gbxVarutyp = new GroupBox();
            tbxPris = new TextBox();
            lblPris = new Label();
            tbxMängd = new TextBox();
            lblMängd = new Label();
            lbxVaruLista = new ListBox();
            tbxSumma = new TextBox();
            lblSumma = new Label();
            btnLäggTill = new Button();
            tbxSorteraNamn = new Button();
            btnSorteraPris = new Button();
            gbxVarutyp.SuspendLayout();
            SuspendLayout();
            // 
            // lblVara
            // 
            lblVara.AutoSize = true;
            lblVara.Location = new Point(27, 23);
            lblVara.Name = "lblVara";
            lblVara.Size = new Size(29, 15);
            lblVara.TabIndex = 0;
            lblVara.Text = "Vara";
            // 
            // tbxVara
            // 
            tbxVara.Location = new Point(194, 20);
            tbxVara.Name = "tbxVara";
            tbxVara.Size = new Size(100, 23);
            tbxVara.TabIndex = 1;
            // 
            // rbnLösvikt
            // 
            rbnLösvikt.AutoSize = true;
            rbnLösvikt.Location = new Point(6, 22);
            rbnLösvikt.Name = "rbnLösvikt";
            rbnLösvikt.Size = new Size(62, 19);
            rbnLösvikt.TabIndex = 2;
            rbnLösvikt.TabStop = true;
            rbnLösvikt.Text = "Lösvikt";
            rbnLösvikt.UseVisualStyleBackColor = true;
            // 
            // rbnStycksak
            // 
            rbnStycksak.AutoSize = true;
            rbnStycksak.Location = new Point(6, 47);
            rbnStycksak.Name = "rbnStycksak";
            rbnStycksak.Size = new Size(70, 19);
            rbnStycksak.TabIndex = 3;
            rbnStycksak.TabStop = true;
            rbnStycksak.Text = "Stycksak";
            rbnStycksak.UseVisualStyleBackColor = true;
            // 
            // gbxVarutyp
            // 
            gbxVarutyp.Controls.Add(rbnLösvikt);
            gbxVarutyp.Controls.Add(rbnStycksak);
            gbxVarutyp.Location = new Point(178, 111);
            gbxVarutyp.Name = "gbxVarutyp";
            gbxVarutyp.Size = new Size(116, 75);
            gbxVarutyp.TabIndex = 4;
            gbxVarutyp.TabStop = false;
            gbxVarutyp.Text = "Varutyp";
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(194, 49);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(100, 23);
            tbxPris.TabIndex = 6;
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(27, 52);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(26, 15);
            lblPris.TabIndex = 5;
            lblPris.Text = "Pris";
            // 
            // tbxMängd
            // 
            tbxMängd.Location = new Point(194, 78);
            tbxMängd.Name = "tbxMängd";
            tbxMängd.Size = new Size(100, 23);
            tbxMängd.TabIndex = 8;
            // 
            // lblMängd
            // 
            lblMängd.AutoSize = true;
            lblMängd.Location = new Point(27, 81);
            lblMängd.Name = "lblMängd";
            lblMängd.Size = new Size(45, 15);
            lblMängd.TabIndex = 7;
            lblMängd.Text = "Mängd";
            // 
            // lbxVaruLista
            // 
            lbxVaruLista.FormattingEnabled = true;
            lbxVaruLista.ItemHeight = 15;
            lbxVaruLista.Location = new Point(386, 20);
            lbxVaruLista.Name = "lbxVaruLista";
            lbxVaruLista.Size = new Size(294, 289);
            lbxVaruLista.TabIndex = 9;
            // 
            // tbxSumma
            // 
            tbxSumma.Location = new Point(560, 315);
            tbxSumma.Name = "tbxSumma";
            tbxSumma.Size = new Size(100, 23);
            tbxSumma.TabIndex = 11;
            // 
            // lblSumma
            // 
            lblSumma.AutoSize = true;
            lblSumma.Location = new Point(393, 318);
            lblSumma.Name = "lblSumma";
            lblSumma.Size = new Size(72, 15);
            lblSumma.TabIndex = 10;
            lblSumma.Text = "Summa (kr):";
            // 
            // btnLäggTill
            // 
            btnLäggTill.Location = new Point(27, 315);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(111, 23);
            btnLäggTill.TabIndex = 12;
            btnLäggTill.Text = "Lägg till";
            btnLäggTill.UseVisualStyleBackColor = true;
            btnLäggTill.Click += btnLäggTill_Click;
            // 
            // tbxSorteraNamn
            // 
            tbxSorteraNamn.Location = new Point(27, 364);
            tbxSorteraNamn.Name = "tbxSorteraNamn";
            tbxSorteraNamn.Size = new Size(111, 23);
            tbxSorteraNamn.TabIndex = 13;
            tbxSorteraNamn.Text = "Sortera namn";
            tbxSorteraNamn.UseVisualStyleBackColor = true;
            tbxSorteraNamn.Click += tbxSorteraNamn_Click;
            // 
            // btnSorteraPris
            // 
            btnSorteraPris.Location = new Point(27, 403);
            btnSorteraPris.Name = "btnSorteraPris";
            btnSorteraPris.Size = new Size(111, 23);
            btnSorteraPris.TabIndex = 14;
            btnSorteraPris.Text = "Sortera pris";
            btnSorteraPris.UseVisualStyleBackColor = true;
            btnSorteraPris.Click += btnSorteraPris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSorteraPris);
            Controls.Add(tbxSorteraNamn);
            Controls.Add(btnLäggTill);
            Controls.Add(tbxSumma);
            Controls.Add(lblSumma);
            Controls.Add(lbxVaruLista);
            Controls.Add(tbxMängd);
            Controls.Add(lblMängd);
            Controls.Add(tbxPris);
            Controls.Add(lblPris);
            Controls.Add(gbxVarutyp);
            Controls.Add(tbxVara);
            Controls.Add(lblVara);
            Name = "Form1";
            Text = "Form1";
            gbxVarutyp.ResumeLayout(false);
            gbxVarutyp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVara;
        private TextBox tbxVara;
        private RadioButton rbnLösvikt;
        private RadioButton rbnStycksak;
        private GroupBox gbxVarutyp;
        private TextBox tbxPris;
        private Label lblPris;
        private TextBox tbxMängd;
        private Label lblMängd;
        private ListBox lbxVaruLista;
        private TextBox tbxSumma;
        private Label lblSumma;
        private Button btnLäggTill;
        private Button tbxSorteraNamn;
        private Button btnSorteraPris;
    }
}