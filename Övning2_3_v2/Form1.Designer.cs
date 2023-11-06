namespace Övning2_3_v2
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
            this.gbxInsättningUttag = new System.Windows.Forms.GroupBox();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnInsättning = new System.Windows.Forms.Button();
            this.lblBelopp = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.gbxÖppnaKonto = new System.Windows.Forms.GroupBox();
            this.lblKredit = new System.Windows.Forms.Label();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.lblRäntesats = new System.Windows.Forms.Label();
            this.tbxRäntesats = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.btnÅrsränta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBehållningBank = new System.Windows.Forms.TextBox();
            this.gbxInsättningUttag.SuspendLayout();
            this.gbxÖppnaKonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInsättningUttag
            // 
            this.gbxInsättningUttag.Controls.Add(this.btnUttag);
            this.gbxInsättningUttag.Controls.Add(this.btnInsättning);
            this.gbxInsättningUttag.Controls.Add(this.lblBelopp);
            this.gbxInsättningUttag.Controls.Add(this.tbxBelopp);
            this.gbxInsättningUttag.Location = new System.Drawing.Point(33, 25);
            this.gbxInsättningUttag.Name = "gbxInsättningUttag";
            this.gbxInsättningUttag.Size = new System.Drawing.Size(260, 166);
            this.gbxInsättningUttag.TabIndex = 0;
            this.gbxInsättningUttag.TabStop = false;
            this.gbxInsättningUttag.Text = "Insättning/Uttag";
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(165, 121);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 3;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.btnUttag_Click);
            // 
            // btnInsättning
            // 
            this.btnInsättning.Location = new System.Drawing.Point(165, 92);
            this.btnInsättning.Name = "btnInsättning";
            this.btnInsättning.Size = new System.Drawing.Size(75, 23);
            this.btnInsättning.TabIndex = 2;
            this.btnInsättning.Text = "Insättning";
            this.btnInsättning.UseVisualStyleBackColor = true;
            this.btnInsättning.Click += new System.EventHandler(this.btnInsättning_Click);
            // 
            // lblBelopp
            // 
            this.lblBelopp.AutoSize = true;
            this.lblBelopp.Location = new System.Drawing.Point(28, 38);
            this.lblBelopp.Name = "lblBelopp";
            this.lblBelopp.Size = new System.Drawing.Size(40, 13);
            this.lblBelopp.TabIndex = 1;
            this.lblBelopp.Text = "Belopp";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(154, 32);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxBelopp.TabIndex = 0;
            // 
            // gbxÖppnaKonto
            // 
            this.gbxÖppnaKonto.Controls.Add(this.lblKredit);
            this.gbxÖppnaKonto.Controls.Add(this.tbxKredit);
            this.gbxÖppnaKonto.Controls.Add(this.lblRäntesats);
            this.gbxÖppnaKonto.Controls.Add(this.tbxRäntesats);
            this.gbxÖppnaKonto.Controls.Add(this.btnRegistrera);
            this.gbxÖppnaKonto.Controls.Add(this.lblPersonNr);
            this.gbxÖppnaKonto.Controls.Add(this.tbxPersonNr);
            this.gbxÖppnaKonto.Location = new System.Drawing.Point(330, 25);
            this.gbxÖppnaKonto.Name = "gbxÖppnaKonto";
            this.gbxÖppnaKonto.Size = new System.Drawing.Size(260, 166);
            this.gbxÖppnaKonto.TabIndex = 4;
            this.gbxÖppnaKonto.TabStop = false;
            this.gbxÖppnaKonto.Text = "Öppna Konto";
            // 
            // lblKredit
            // 
            this.lblKredit.AutoSize = true;
            this.lblKredit.Location = new System.Drawing.Point(28, 98);
            this.lblKredit.Name = "lblKredit";
            this.lblKredit.Size = new System.Drawing.Size(34, 13);
            this.lblKredit.TabIndex = 7;
            this.lblKredit.Text = "Kredit";
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(154, 92);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(100, 20);
            this.tbxKredit.TabIndex = 6;
            // 
            // lblRäntesats
            // 
            this.lblRäntesats.AutoSize = true;
            this.lblRäntesats.Location = new System.Drawing.Point(28, 64);
            this.lblRäntesats.Name = "lblRäntesats";
            this.lblRäntesats.Size = new System.Drawing.Size(55, 13);
            this.lblRäntesats.TabIndex = 5;
            this.lblRäntesats.Text = "Räntesats";
            // 
            // tbxRäntesats
            // 
            this.tbxRäntesats.Location = new System.Drawing.Point(154, 58);
            this.tbxRäntesats.Name = "tbxRäntesats";
            this.tbxRäntesats.Size = new System.Drawing.Size(100, 20);
            this.tbxRäntesats.TabIndex = 4;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(165, 121);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 3;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.Location = new System.Drawing.Point(28, 38);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(51, 13);
            this.lblPersonNr.TabIndex = 1;
            this.lblPersonNr.Text = "PersonNr";
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(154, 32);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbxPersonNr.TabIndex = 0;
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(33, 216);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(451, 186);
            this.lbxLista.TabIndex = 5;
            // 
            // btnÅrsränta
            // 
            this.btnÅrsränta.Location = new System.Drawing.Point(33, 415);
            this.btnÅrsränta.Name = "btnÅrsränta";
            this.btnÅrsränta.Size = new System.Drawing.Size(219, 23);
            this.btnÅrsränta.TabIndex = 8;
            this.btnÅrsränta.Text = "Uppdatera med årsränta";
            this.btnÅrsränta.UseVisualStyleBackColor = true;
            this.btnÅrsränta.Click += new System.EventHandler(this.btnÅrsränta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Behållning bank";
            // 
            // tbxBehållningBank
            // 
            this.tbxBehållningBank.Location = new System.Drawing.Point(629, 216);
            this.tbxBehållningBank.Name = "tbxBehållningBank";
            this.tbxBehållningBank.Size = new System.Drawing.Size(100, 20);
            this.tbxBehållningBank.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnÅrsränta);
            this.Controls.Add(this.tbxBehållningBank);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.gbxÖppnaKonto);
            this.Controls.Add(this.gbxInsättningUttag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxInsättningUttag.ResumeLayout(false);
            this.gbxInsättningUttag.PerformLayout();
            this.gbxÖppnaKonto.ResumeLayout(false);
            this.gbxÖppnaKonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInsättningUttag;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnInsättning;
        private System.Windows.Forms.Label lblBelopp;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.GroupBox gbxÖppnaKonto;
        private System.Windows.Forms.Label lblKredit;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.Label lblRäntesats;
        private System.Windows.Forms.TextBox tbxRäntesats;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Label lblPersonNr;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Button btnÅrsränta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBehållningBank;
    }
}

