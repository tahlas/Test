namespace Övning2_3
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
            gbxInsättningUttag = new GroupBox();
            btnUttag = new Button();
            btnInsättning = new Button();
            lblBelopp = new Label();
            tbxBelopp = new TextBox();
            gbxÖppnaKonto = new GroupBox();
            lblKredit = new Label();
            tbxKredit = new TextBox();
            lblRäntesats = new Label();
            tbxRäntesats = new TextBox();
            btnRegistrera = new Button();
            lblPersonNr = new Label();
            tbxPersonNr = new TextBox();
            lbxList = new ListBox();
            btnUppdatera = new Button();
            lblBehållning = new Label();
            tbxBehållning = new TextBox();
            gbxInsättningUttag.SuspendLayout();
            gbxÖppnaKonto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxInsättningUttag
            // 
            gbxInsättningUttag.Controls.Add(btnUttag);
            gbxInsättningUttag.Controls.Add(btnInsättning);
            gbxInsättningUttag.Controls.Add(lblBelopp);
            gbxInsättningUttag.Controls.Add(tbxBelopp);
            gbxInsättningUttag.Location = new Point(29, 25);
            gbxInsättningUttag.Name = "gbxInsättningUttag";
            gbxInsättningUttag.Size = new Size(249, 174);
            gbxInsättningUttag.TabIndex = 0;
            gbxInsättningUttag.TabStop = false;
            gbxInsättningUttag.Text = "Insättning/Uttag";
            // 
            // btnUttag
            // 
            btnUttag.Location = new Point(82, 134);
            btnUttag.Name = "btnUttag";
            btnUttag.Size = new Size(75, 23);
            btnUttag.TabIndex = 3;
            btnUttag.Text = "Uttag";
            btnUttag.UseVisualStyleBackColor = true;
            // 
            // btnInsättning
            // 
            btnInsättning.Location = new Point(82, 108);
            btnInsättning.Name = "btnInsättning";
            btnInsättning.Size = new Size(75, 23);
            btnInsättning.TabIndex = 2;
            btnInsättning.Text = "Insättning";
            btnInsättning.UseVisualStyleBackColor = true;
            btnInsättning.Click += btnInsättning_Click;
            // 
            // lblBelopp
            // 
            lblBelopp.AutoSize = true;
            lblBelopp.Location = new Point(10, 26);
            lblBelopp.Name = "lblBelopp";
            lblBelopp.Size = new Size(44, 15);
            lblBelopp.TabIndex = 1;
            lblBelopp.Text = "Belopp";
            // 
            // tbxBelopp
            // 
            tbxBelopp.Location = new Point(82, 23);
            tbxBelopp.Name = "tbxBelopp";
            tbxBelopp.Size = new Size(100, 23);
            tbxBelopp.TabIndex = 0;
            // 
            // gbxÖppnaKonto
            // 
            gbxÖppnaKonto.Controls.Add(lblKredit);
            gbxÖppnaKonto.Controls.Add(tbxKredit);
            gbxÖppnaKonto.Controls.Add(lblRäntesats);
            gbxÖppnaKonto.Controls.Add(tbxRäntesats);
            gbxÖppnaKonto.Controls.Add(btnRegistrera);
            gbxÖppnaKonto.Controls.Add(lblPersonNr);
            gbxÖppnaKonto.Controls.Add(tbxPersonNr);
            gbxÖppnaKonto.Location = new Point(335, 25);
            gbxÖppnaKonto.Name = "gbxÖppnaKonto";
            gbxÖppnaKonto.Size = new Size(249, 174);
            gbxÖppnaKonto.TabIndex = 4;
            gbxÖppnaKonto.TabStop = false;
            gbxÖppnaKonto.Text = "Öppna konto";
            // 
            // lblKredit
            // 
            lblKredit.AutoSize = true;
            lblKredit.Location = new Point(10, 82);
            lblKredit.Name = "lblKredit";
            lblKredit.Size = new Size(38, 15);
            lblKredit.TabIndex = 7;
            lblKredit.Text = "Kredit";
            // 
            // tbxKredit
            // 
            tbxKredit.Location = new Point(82, 79);
            tbxKredit.Name = "tbxKredit";
            tbxKredit.Size = new Size(100, 23);
            tbxKredit.TabIndex = 6;
            // 
            // lblRäntesats
            // 
            lblRäntesats.AutoSize = true;
            lblRäntesats.Location = new Point(10, 55);
            lblRäntesats.Name = "lblRäntesats";
            lblRäntesats.Size = new Size(57, 15);
            lblRäntesats.TabIndex = 5;
            lblRäntesats.Text = "Räntesats";
            // 
            // tbxRäntesats
            // 
            tbxRäntesats.Location = new Point(82, 52);
            tbxRäntesats.Name = "tbxRäntesats";
            tbxRäntesats.Size = new Size(100, 23);
            tbxRäntesats.TabIndex = 4;
            // 
            // btnRegistrera
            // 
            btnRegistrera.Location = new Point(82, 124);
            btnRegistrera.Name = "btnRegistrera";
            btnRegistrera.Size = new Size(75, 23);
            btnRegistrera.TabIndex = 3;
            btnRegistrera.Text = "Registrera";
            btnRegistrera.UseVisualStyleBackColor = true;
            btnRegistrera.Click += btnRegistrera_Click;
            // 
            // lblPersonNr
            // 
            lblPersonNr.AutoSize = true;
            lblPersonNr.Location = new Point(10, 26);
            lblPersonNr.Name = "lblPersonNr";
            lblPersonNr.Size = new Size(56, 15);
            lblPersonNr.TabIndex = 1;
            lblPersonNr.Text = "PersonNr";
            // 
            // tbxPersonNr
            // 
            tbxPersonNr.Location = new Point(82, 23);
            tbxPersonNr.Name = "tbxPersonNr";
            tbxPersonNr.Size = new Size(100, 23);
            tbxPersonNr.TabIndex = 0;
            // 
            // lbxList
            // 
            lbxList.FormattingEnabled = true;
            lbxList.ItemHeight = 15;
            lbxList.Location = new Point(590, 33);
            lbxList.Name = "lbxList";
            lbxList.Size = new Size(236, 139);
            lbxList.TabIndex = 5;
            // 
            // btnUppdatera
            // 
            btnUppdatera.Location = new Point(590, 176);
            btnUppdatera.Name = "btnUppdatera";
            btnUppdatera.Size = new Size(236, 23);
            btnUppdatera.TabIndex = 8;
            btnUppdatera.Text = "Uppdatera med årsränta";
            btnUppdatera.UseVisualStyleBackColor = true;
            // 
            // lblBehållning
            // 
            lblBehållning.AutoSize = true;
            lblBehållning.Location = new Point(588, 213);
            lblBehållning.Name = "lblBehållning";
            lblBehållning.Size = new Size(92, 15);
            lblBehållning.TabIndex = 9;
            lblBehållning.Text = "Behållning bank";
            // 
            // tbxBehållning
            // 
            tbxBehållning.Location = new Point(686, 205);
            tbxBehållning.Name = "tbxBehållning";
            tbxBehållning.Size = new Size(100, 23);
            tbxBehållning.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 248);
            Controls.Add(lblBehållning);
            Controls.Add(btnUppdatera);
            Controls.Add(tbxBehållning);
            Controls.Add(lbxList);
            Controls.Add(gbxÖppnaKonto);
            Controls.Add(gbxInsättningUttag);
            Name = "Form1";
            Text = "Form1";
            gbxInsättningUttag.ResumeLayout(false);
            gbxInsättningUttag.PerformLayout();
            gbxÖppnaKonto.ResumeLayout(false);
            gbxÖppnaKonto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxInsättningUttag;
        private Button btnUttag;
        private Button btnInsättning;
        private Label lblBelopp;
        private TextBox tbxBelopp;
        private GroupBox gbxÖppnaKonto;
        private Label lblKredit;
        private TextBox tbxKredit;
        private Label lblRäntesats;
        private TextBox tbxRäntesats;
        private Button btnRegistrera;
        private Label lblPersonNr;
        private TextBox tbxPersonNr;
        private ListBox lbxList;
        private Button btnUppdatera;
        private Label lblBehållning;
        private TextBox tbxBehållning;
    }
}