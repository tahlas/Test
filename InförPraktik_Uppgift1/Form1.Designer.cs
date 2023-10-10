namespace InförPraktik_Uppgift1
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
            this.lblFärg = new System.Windows.Forms.Label();
            this.tbxFärg = new System.Windows.Forms.TextBox();
            this.tbxValör = new System.Windows.Forms.TextBox();
            this.lblValör = new System.Windows.Forms.Label();
            this.btnLägg = new System.Windows.Forms.Button();
            this.tbxTaBort = new System.Windows.Forms.Button();
            this.lbxKort = new System.Windows.Forms.ListBox();
            this.btnPar = new System.Windows.Forms.Button();
            this.tbxPar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFärg
            // 
            this.lblFärg.AutoSize = true;
            this.lblFärg.Location = new System.Drawing.Point(41, 27);
            this.lblFärg.Name = "lblFärg";
            this.lblFärg.Size = new System.Drawing.Size(31, 13);
            this.lblFärg.TabIndex = 0;
            this.lblFärg.Text = "Färg:";
            // 
            // tbxFärg
            // 
            this.tbxFärg.Location = new System.Drawing.Point(101, 27);
            this.tbxFärg.Name = "tbxFärg";
            this.tbxFärg.Size = new System.Drawing.Size(125, 20);
            this.tbxFärg.TabIndex = 1;
            // 
            // tbxValör
            // 
            this.tbxValör.Location = new System.Drawing.Point(101, 70);
            this.tbxValör.Name = "tbxValör";
            this.tbxValör.Size = new System.Drawing.Size(125, 20);
            this.tbxValör.TabIndex = 3;
            // 
            // lblValör
            // 
            this.lblValör.AutoSize = true;
            this.lblValör.Location = new System.Drawing.Point(41, 70);
            this.lblValör.Name = "lblValör";
            this.lblValör.Size = new System.Drawing.Size(34, 13);
            this.lblValör.TabIndex = 2;
            this.lblValör.Text = "Valör:";
            // 
            // btnLägg
            // 
            this.btnLägg.Location = new System.Drawing.Point(44, 111);
            this.btnLägg.Name = "btnLägg";
            this.btnLägg.Size = new System.Drawing.Size(75, 23);
            this.btnLägg.TabIndex = 4;
            this.btnLägg.Text = "Lägg till";
            this.btnLägg.UseVisualStyleBackColor = true;
            this.btnLägg.Click += new System.EventHandler(this.btnLägg_Click);
            // 
            // tbxTaBort
            // 
            this.tbxTaBort.Location = new System.Drawing.Point(126, 111);
            this.tbxTaBort.Name = "tbxTaBort";
            this.tbxTaBort.Size = new System.Drawing.Size(75, 23);
            this.tbxTaBort.TabIndex = 5;
            this.tbxTaBort.Text = "Ta bort";
            this.tbxTaBort.UseVisualStyleBackColor = true;
            this.tbxTaBort.Click += new System.EventHandler(this.tbxTaBort_Click);
            // 
            // lbxKort
            // 
            this.lbxKort.FormattingEnabled = true;
            this.lbxKort.Location = new System.Drawing.Point(44, 171);
            this.lbxKort.Name = "lbxKort";
            this.lbxKort.Size = new System.Drawing.Size(266, 95);
            this.lbxKort.TabIndex = 6;
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(44, 272);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 7;
            this.btnPar.Text = "Par";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // tbxPar
            // 
            this.tbxPar.Location = new System.Drawing.Point(126, 274);
            this.tbxPar.Name = "tbxPar";
            this.tbxPar.ReadOnly = true;
            this.tbxPar.Size = new System.Drawing.Size(184, 20);
            this.tbxPar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 359);
            this.Controls.Add(this.tbxPar);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.lbxKort);
            this.Controls.Add(this.tbxTaBort);
            this.Controls.Add(this.btnLägg);
            this.Controls.Add(this.tbxValör);
            this.Controls.Add(this.lblValör);
            this.Controls.Add(this.tbxFärg);
            this.Controls.Add(this.lblFärg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFärg;
        private System.Windows.Forms.TextBox tbxFärg;
        private System.Windows.Forms.TextBox tbxValör;
        private System.Windows.Forms.Label lblValör;
        private System.Windows.Forms.Button btnLägg;
        private System.Windows.Forms.Button tbxTaBort;
        private System.Windows.Forms.ListBox lbxKort;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.TextBox tbxPar;
    }
}

