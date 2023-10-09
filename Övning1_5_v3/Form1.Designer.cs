namespace Övning1_5_v3
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
            this.gbpVisa = new System.Windows.Forms.GroupBox();
            this.rbnMC = new System.Windows.Forms.RadioButton();
            this.rbnBilar = new System.Windows.Forms.RadioButton();
            this.rbnAlla = new System.Windows.Forms.RadioButton();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.lbxRegister = new System.Windows.Forms.ListBox();
            this.cbxTyp = new System.Windows.Forms.ComboBox();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblModell = new System.Windows.Forms.Label();
            this.tbxModell = new System.Windows.Forms.TextBox();
            this.lblMärke = new System.Windows.Forms.Label();
            this.tbxMärke = new System.Windows.Forms.TextBox();
            this.lblRegNr = new System.Windows.Forms.Label();
            this.tbxRegNr = new System.Windows.Forms.TextBox();
            this.gbpVisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpVisa
            // 
            this.gbpVisa.Controls.Add(this.rbnMC);
            this.gbpVisa.Controls.Add(this.rbnBilar);
            this.gbpVisa.Controls.Add(this.rbnAlla);
            this.gbpVisa.Location = new System.Drawing.Point(425, 305);
            this.gbpVisa.Name = "gbpVisa";
            this.gbpVisa.Size = new System.Drawing.Size(287, 64);
            this.gbpVisa.TabIndex = 25;
            this.gbpVisa.TabStop = false;
            this.gbpVisa.Text = "Visa";
            // 
            // rbnMC
            // 
            this.rbnMC.AutoSize = true;
            this.rbnMC.Location = new System.Drawing.Point(196, 19);
            this.rbnMC.Name = "rbnMC";
            this.rbnMC.Size = new System.Drawing.Size(41, 17);
            this.rbnMC.TabIndex = 2;
            this.rbnMC.TabStop = true;
            this.rbnMC.Text = "MC";
            this.rbnMC.UseVisualStyleBackColor = true;
            this.rbnMC.CheckedChanged += new System.EventHandler(this.rbnMC_CheckedChanged);
            // 
            // rbnBilar
            // 
            this.rbnBilar.AutoSize = true;
            this.rbnBilar.Location = new System.Drawing.Point(98, 19);
            this.rbnBilar.Name = "rbnBilar";
            this.rbnBilar.Size = new System.Drawing.Size(45, 17);
            this.rbnBilar.TabIndex = 1;
            this.rbnBilar.TabStop = true;
            this.rbnBilar.Text = "Bilar";
            this.rbnBilar.UseVisualStyleBackColor = true;
            this.rbnBilar.CheckedChanged += new System.EventHandler(this.rbnBilar_CheckedChanged);
            // 
            // rbnAlla
            // 
            this.rbnAlla.AutoSize = true;
            this.rbnAlla.Location = new System.Drawing.Point(7, 20);
            this.rbnAlla.Name = "rbnAlla";
            this.rbnAlla.Size = new System.Drawing.Size(42, 17);
            this.rbnAlla.TabIndex = 0;
            this.rbnAlla.TabStop = true;
            this.rbnAlla.Text = "Alla";
            this.rbnAlla.UseVisualStyleBackColor = true;
            this.rbnAlla.CheckedChanged += new System.EventHandler(this.rbnAlla_CheckedChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(422, 81);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(39, 13);
            this.lblRegister.TabIndex = 24;
            this.lblRegister.Text = "Reg-nr";
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(150, 296);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 23;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // lbxRegister
            // 
            this.lbxRegister.FormattingEnabled = true;
            this.lbxRegister.Location = new System.Drawing.Point(425, 97);
            this.lbxRegister.Name = "lbxRegister";
            this.lbxRegister.Size = new System.Drawing.Size(287, 186);
            this.lbxRegister.TabIndex = 22;
            // 
            // cbxTyp
            // 
            this.cbxTyp.FormattingEnabled = true;
            this.cbxTyp.Items.AddRange(new object[] {
            "Bil",
            "Motorcykel"});
            this.cbxTyp.Location = new System.Drawing.Point(150, 254);
            this.cbxTyp.Name = "cbxTyp";
            this.cbxTyp.Size = new System.Drawing.Size(100, 21);
            this.cbxTyp.TabIndex = 21;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(89, 257);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(25, 13);
            this.lblTyp.TabIndex = 20;
            this.lblTyp.Text = "Typ";
            // 
            // lblModell
            // 
            this.lblModell.AutoSize = true;
            this.lblModell.Location = new System.Drawing.Point(89, 219);
            this.lblModell.Name = "lblModell";
            this.lblModell.Size = new System.Drawing.Size(38, 13);
            this.lblModell.TabIndex = 19;
            this.lblModell.Text = "Modell";
            // 
            // tbxModell
            // 
            this.tbxModell.Location = new System.Drawing.Point(150, 213);
            this.tbxModell.Name = "tbxModell";
            this.tbxModell.Size = new System.Drawing.Size(100, 20);
            this.tbxModell.TabIndex = 18;
            // 
            // lblMärke
            // 
            this.lblMärke.AutoSize = true;
            this.lblMärke.Location = new System.Drawing.Point(89, 179);
            this.lblMärke.Name = "lblMärke";
            this.lblMärke.Size = new System.Drawing.Size(37, 13);
            this.lblMärke.TabIndex = 17;
            this.lblMärke.Text = "Märke";
            // 
            // tbxMärke
            // 
            this.tbxMärke.Location = new System.Drawing.Point(150, 173);
            this.tbxMärke.Name = "tbxMärke";
            this.tbxMärke.Size = new System.Drawing.Size(100, 20);
            this.tbxMärke.TabIndex = 16;
            // 
            // lblRegNr
            // 
            this.lblRegNr.AutoSize = true;
            this.lblRegNr.Location = new System.Drawing.Point(89, 144);
            this.lblRegNr.Name = "lblRegNr";
            this.lblRegNr.Size = new System.Drawing.Size(39, 13);
            this.lblRegNr.TabIndex = 15;
            this.lblRegNr.Text = "Reg-nr";
            // 
            // tbxRegNr
            // 
            this.tbxRegNr.Location = new System.Drawing.Point(150, 138);
            this.tbxRegNr.Name = "tbxRegNr";
            this.tbxRegNr.Size = new System.Drawing.Size(100, 20);
            this.tbxRegNr.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbpVisa);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.lbxRegister);
            this.Controls.Add(this.cbxTyp);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblModell);
            this.Controls.Add(this.tbxModell);
            this.Controls.Add(this.lblMärke);
            this.Controls.Add(this.tbxMärke);
            this.Controls.Add(this.lblRegNr);
            this.Controls.Add(this.tbxRegNr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbpVisa.ResumeLayout(false);
            this.gbpVisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpVisa;
        private System.Windows.Forms.RadioButton rbnMC;
        private System.Windows.Forms.RadioButton rbnBilar;
        private System.Windows.Forms.RadioButton rbnAlla;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.ListBox lbxRegister;
        private System.Windows.Forms.ComboBox cbxTyp;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblModell;
        private System.Windows.Forms.TextBox tbxModell;
        private System.Windows.Forms.Label lblMärke;
        private System.Windows.Forms.TextBox tbxMärke;
        private System.Windows.Forms.Label lblRegNr;
        private System.Windows.Forms.TextBox tbxRegNr;
    }
}

