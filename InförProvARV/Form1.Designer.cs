namespace InförProvARV
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
            lblTitel = new Label();
            tbxTitel = new TextBox();
            btnLäggTill = new Button();
            lbxLista = new ListBox();
            gbxLäggTill = new GroupBox();
            label3 = new Label();
            tbxAntalLåtar = new TextBox();
            label2 = new Label();
            tbxFörfattareArtist = new TextBox();
            label1 = new Label();
            tbxSidorLängd = new TextBox();
            rbnCD = new RadioButton();
            rbnBok = new RadioButton();
            lblTyp = new Label();
            lblPris = new Label();
            tbxPris = new TextBox();
            lblUtgivningsÅr = new Label();
            tbxUtgivningsÅr = new TextBox();
            gbxÄndra = new GroupBox();
            label4 = new Label();
            tbxAntalLåtar2 = new TextBox();
            label5 = new Label();
            tbxFörfattareArtist2 = new TextBox();
            label6 = new Label();
            tbxSidorLängd2 = new TextBox();
            btnÄndra = new Button();
            label8 = new Label();
            tbxPris2 = new TextBox();
            label9 = new Label();
            tbxUtgivningsÅr2 = new TextBox();
            label10 = new Label();
            tbxTitel2 = new TextBox();
            btnSorteraPris = new Button();
            gbxLäggTill.SuspendLayout();
            gbxÄndra.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(20, 51);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(32, 15);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Titel:";
            // 
            // tbxTitel
            // 
            tbxTitel.Location = new Point(129, 43);
            tbxTitel.Name = "tbxTitel";
            tbxTitel.Size = new Size(100, 23);
            tbxTitel.TabIndex = 1;
            // 
            // btnLäggTill
            // 
            btnLäggTill.Location = new Point(129, 233);
            btnLäggTill.Name = "btnLäggTill";
            btnLäggTill.Size = new Size(100, 23);
            btnLäggTill.TabIndex = 2;
            btnLäggTill.Text = "Lägg till";
            btnLäggTill.UseVisualStyleBackColor = true;
            btnLäggTill.Click += btnLäggTill_Click;
            // 
            // lbxLista
            // 
            lbxLista.FormattingEnabled = true;
            lbxLista.ItemHeight = 15;
            lbxLista.Location = new Point(304, 32);
            lbxLista.Name = "lbxLista";
            lbxLista.Size = new Size(688, 544);
            lbxLista.TabIndex = 3;
            // 
            // gbxLäggTill
            // 
            gbxLäggTill.Controls.Add(label3);
            gbxLäggTill.Controls.Add(tbxAntalLåtar);
            gbxLäggTill.Controls.Add(label2);
            gbxLäggTill.Controls.Add(tbxFörfattareArtist);
            gbxLäggTill.Controls.Add(label1);
            gbxLäggTill.Controls.Add(tbxSidorLängd);
            gbxLäggTill.Controls.Add(rbnCD);
            gbxLäggTill.Controls.Add(rbnBok);
            gbxLäggTill.Controls.Add(btnLäggTill);
            gbxLäggTill.Controls.Add(lblTyp);
            gbxLäggTill.Controls.Add(lblPris);
            gbxLäggTill.Controls.Add(tbxPris);
            gbxLäggTill.Controls.Add(lblUtgivningsÅr);
            gbxLäggTill.Controls.Add(tbxUtgivningsÅr);
            gbxLäggTill.Controls.Add(lblTitel);
            gbxLäggTill.Controls.Add(tbxTitel);
            gbxLäggTill.Location = new Point(12, 32);
            gbxLäggTill.Name = "gbxLäggTill";
            gbxLäggTill.Size = new Size(286, 279);
            gbxLäggTill.TabIndex = 4;
            gbxLäggTill.TabStop = false;
            gbxLäggTill.Text = "Lägg till";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 196);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Antal låtar:";
            // 
            // tbxAntalLåtar
            // 
            tbxAntalLåtar.Location = new Point(129, 188);
            tbxAntalLåtar.Name = "tbxAntalLåtar";
            tbxAntalLåtar.Size = new Size(100, 23);
            tbxAntalLåtar.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 167);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 9;
            label2.Text = "Författare/Artist:";
            // 
            // tbxFörfattareArtist
            // 
            tbxFörfattareArtist.Location = new Point(129, 159);
            tbxFörfattareArtist.Name = "tbxFörfattareArtist";
            tbxFörfattareArtist.Size = new Size(100, 23);
            tbxFörfattareArtist.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 138);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Sidor/Längd:";
            // 
            // tbxSidorLängd
            // 
            tbxSidorLängd.Location = new Point(129, 130);
            tbxSidorLängd.Name = "tbxSidorLängd";
            tbxSidorLängd.Size = new Size(100, 23);
            tbxSidorLängd.TabIndex = 8;
            // 
            // rbnCD
            // 
            rbnCD.AutoSize = true;
            rbnCD.Location = new Point(179, 18);
            rbnCD.Name = "rbnCD";
            rbnCD.Size = new Size(41, 19);
            rbnCD.TabIndex = 6;
            rbnCD.TabStop = true;
            rbnCD.Text = "CD";
            rbnCD.UseVisualStyleBackColor = true;
            // 
            // rbnBok
            // 
            rbnBok.AutoSize = true;
            rbnBok.Location = new Point(128, 18);
            rbnBok.Name = "rbnBok";
            rbnBok.Size = new Size(45, 19);
            rbnBok.TabIndex = 5;
            rbnBok.TabStop = true;
            rbnBok.Text = "Bok";
            rbnBok.UseVisualStyleBackColor = true;
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(20, 19);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(28, 15);
            lblTyp.TabIndex = 6;
            lblTyp.Text = "Typ:";
            // 
            // lblPris
            // 
            lblPris.AutoSize = true;
            lblPris.Location = new Point(20, 109);
            lblPris.Name = "lblPris";
            lblPris.Size = new Size(29, 15);
            lblPris.TabIndex = 4;
            lblPris.Text = "Pris:";
            // 
            // tbxPris
            // 
            tbxPris.Location = new Point(129, 101);
            tbxPris.Name = "tbxPris";
            tbxPris.Size = new Size(100, 23);
            tbxPris.TabIndex = 5;
            // 
            // lblUtgivningsÅr
            // 
            lblUtgivningsÅr.AutoSize = true;
            lblUtgivningsÅr.Location = new Point(20, 80);
            lblUtgivningsÅr.Name = "lblUtgivningsÅr";
            lblUtgivningsÅr.Size = new Size(80, 15);
            lblUtgivningsÅr.TabIndex = 2;
            lblUtgivningsÅr.Text = "Utgivnings år:";
            // 
            // tbxUtgivningsÅr
            // 
            tbxUtgivningsÅr.Location = new Point(129, 72);
            tbxUtgivningsÅr.Name = "tbxUtgivningsÅr";
            tbxUtgivningsÅr.Size = new Size(100, 23);
            tbxUtgivningsÅr.TabIndex = 3;
            // 
            // gbxÄndra
            // 
            gbxÄndra.Controls.Add(label4);
            gbxÄndra.Controls.Add(tbxAntalLåtar2);
            gbxÄndra.Controls.Add(label5);
            gbxÄndra.Controls.Add(tbxFörfattareArtist2);
            gbxÄndra.Controls.Add(label6);
            gbxÄndra.Controls.Add(tbxSidorLängd2);
            gbxÄndra.Controls.Add(btnÄndra);
            gbxÄndra.Controls.Add(label8);
            gbxÄndra.Controls.Add(tbxPris2);
            gbxÄndra.Controls.Add(label9);
            gbxÄndra.Controls.Add(tbxUtgivningsÅr2);
            gbxÄndra.Controls.Add(label10);
            gbxÄndra.Controls.Add(tbxTitel2);
            gbxÄndra.Location = new Point(12, 325);
            gbxÄndra.Name = "gbxÄndra";
            gbxÄndra.Size = new Size(286, 251);
            gbxÄndra.TabIndex = 13;
            gbxÄndra.TabStop = false;
            gbxÄndra.Text = "Ändra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 179);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 11;
            label4.Text = "Antal låtar:";
            // 
            // tbxAntalLåtar2
            // 
            tbxAntalLåtar2.Location = new Point(129, 171);
            tbxAntalLåtar2.Name = "tbxAntalLåtar2";
            tbxAntalLåtar2.Size = new Size(100, 23);
            tbxAntalLåtar2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 150);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 9;
            label5.Text = "Författare/Artist:";
            // 
            // tbxFörfattareArtist2
            // 
            tbxFörfattareArtist2.Location = new Point(129, 142);
            tbxFörfattareArtist2.Name = "tbxFörfattareArtist2";
            tbxFörfattareArtist2.Size = new Size(100, 23);
            tbxFörfattareArtist2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 121);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "Sidor/Längd:";
            // 
            // tbxSidorLängd2
            // 
            tbxSidorLängd2.Location = new Point(129, 113);
            tbxSidorLängd2.Name = "tbxSidorLängd2";
            tbxSidorLängd2.Size = new Size(100, 23);
            tbxSidorLängd2.TabIndex = 8;
            // 
            // btnÄndra
            // 
            btnÄndra.Location = new Point(129, 216);
            btnÄndra.Name = "btnÄndra";
            btnÄndra.Size = new Size(100, 23);
            btnÄndra.TabIndex = 2;
            btnÄndra.Text = "Ändra";
            btnÄndra.UseVisualStyleBackColor = true;
            btnÄndra.Click += btnÄndra_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 92);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 4;
            label8.Text = "Pris:";
            // 
            // tbxPris2
            // 
            tbxPris2.Location = new Point(129, 84);
            tbxPris2.Name = "tbxPris2";
            tbxPris2.Size = new Size(100, 23);
            tbxPris2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 63);
            label9.Name = "label9";
            label9.Size = new Size(80, 15);
            label9.TabIndex = 2;
            label9.Text = "Utgivnings år:";
            // 
            // tbxUtgivningsÅr2
            // 
            tbxUtgivningsÅr2.Location = new Point(129, 55);
            tbxUtgivningsÅr2.Name = "tbxUtgivningsÅr2";
            tbxUtgivningsÅr2.Size = new Size(100, 23);
            tbxUtgivningsÅr2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 34);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 0;
            label10.Text = "Titel:";
            // 
            // tbxTitel2
            // 
            tbxTitel2.Location = new Point(129, 26);
            tbxTitel2.Name = "tbxTitel2";
            tbxTitel2.Size = new Size(100, 23);
            tbxTitel2.TabIndex = 1;
            // 
            // btnSorteraPris
            // 
            btnSorteraPris.Location = new Point(304, 595);
            btnSorteraPris.Name = "btnSorteraPris";
            btnSorteraPris.Size = new Size(100, 23);
            btnSorteraPris.TabIndex = 13;
            btnSorteraPris.Text = "Sortera pris";
            btnSorteraPris.UseVisualStyleBackColor = true;
            btnSorteraPris.Click += btnSorteraPris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 652);
            Controls.Add(btnSorteraPris);
            Controls.Add(gbxÄndra);
            Controls.Add(gbxLäggTill);
            Controls.Add(lbxLista);
            Name = "Form1";
            Text = "Form1";
            gbxLäggTill.ResumeLayout(false);
            gbxLäggTill.PerformLayout();
            gbxÄndra.ResumeLayout(false);
            gbxÄndra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitel;
        private TextBox tbxTitel;
        private Button btnLäggTill;
        private ListBox lbxLista;
        private GroupBox gbxLäggTill;
        private Label lblUtgivningsÅr;
        private TextBox tbxUtgivningsÅr;
        private RadioButton rbnCD;
        private RadioButton rbnBok;
        private Label lblTyp;
        private Label lblPris;
        private TextBox tbxPris;
        private Label label2;
        private TextBox tbxFörfattareArtist;
        private Label label1;
        private TextBox tbxSidorLängd;
        private Label label3;
        private TextBox tbxAntalLåtar;
        private GroupBox gbxÄndra;
        private Label label4;
        private TextBox tbxAntalLåtar2;
        private Label label5;
        private TextBox tbxFörfattareArtist2;
        private Label label6;
        private TextBox tbxSidorLängd2;
        private Button btnÄndra;
        private Label label8;
        private TextBox tbxPris2;
        private Label label9;
        private TextBox tbxUtgivningsÅr2;
        private Label label10;
        private TextBox tbxTitel2;
        private Button btnSorteraPris;
    }
}