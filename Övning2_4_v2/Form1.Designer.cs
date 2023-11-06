namespace Övning2_4_v2
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
            this.gbxSkapa = new System.Windows.Forms.GroupBox();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.btnTriangel = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnLinje = new System.Windows.Forms.Button();
            this.lblBredd = new System.Windows.Forms.Label();
            this.lblHöjd = new System.Windows.Forms.Label();
            this.lbxFigur = new System.Windows.Forms.ListBox();
            this.lblFigurlista = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.gbxSkapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSkapa
            // 
            this.gbxSkapa.Controls.Add(this.lblHöjd);
            this.gbxSkapa.Controls.Add(this.lblBredd);
            this.gbxSkapa.Controls.Add(this.btnLinje);
            this.gbxSkapa.Controls.Add(this.btnCirkel);
            this.gbxSkapa.Controls.Add(this.btnTriangel);
            this.gbxSkapa.Controls.Add(this.tbxHöjd);
            this.gbxSkapa.Controls.Add(this.tbxBredd);
            this.gbxSkapa.Location = new System.Drawing.Point(48, 31);
            this.gbxSkapa.Name = "gbxSkapa";
            this.gbxSkapa.Size = new System.Drawing.Size(265, 179);
            this.gbxSkapa.TabIndex = 0;
            this.gbxSkapa.TabStop = false;
            this.gbxSkapa.Text = "Skapa";
            // 
            // tbxBredd
            // 
            this.tbxBredd.Location = new System.Drawing.Point(89, 37);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(100, 20);
            this.tbxBredd.TabIndex = 0;
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Location = new System.Drawing.Point(89, 63);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(100, 20);
            this.tbxHöjd.TabIndex = 1;
            // 
            // btnTriangel
            // 
            this.btnTriangel.Location = new System.Drawing.Point(89, 89);
            this.btnTriangel.Name = "btnTriangel";
            this.btnTriangel.Size = new System.Drawing.Size(100, 23);
            this.btnTriangel.TabIndex = 2;
            this.btnTriangel.Text = "Skapa triangel";
            this.btnTriangel.UseVisualStyleBackColor = true;
            this.btnTriangel.Click += new System.EventHandler(this.btnTriangel_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(89, 118);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(100, 23);
            this.btnCirkel.TabIndex = 3;
            this.btnCirkel.Text = "Skapa CIrkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnLinje
            // 
            this.btnLinje.Location = new System.Drawing.Point(89, 147);
            this.btnLinje.Name = "btnLinje";
            this.btnLinje.Size = new System.Drawing.Size(100, 23);
            this.btnLinje.TabIndex = 4;
            this.btnLinje.Text = "Skapa linje";
            this.btnLinje.UseVisualStyleBackColor = true;
            this.btnLinje.Click += new System.EventHandler(this.btnLinje_Click);
            // 
            // lblBredd
            // 
            this.lblBredd.AutoSize = true;
            this.lblBredd.Location = new System.Drawing.Point(37, 40);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(35, 13);
            this.lblBredd.TabIndex = 5;
            this.lblBredd.Text = "Bredd";
            // 
            // lblHöjd
            // 
            this.lblHöjd.AutoSize = true;
            this.lblHöjd.Location = new System.Drawing.Point(37, 66);
            this.lblHöjd.Name = "lblHöjd";
            this.lblHöjd.Size = new System.Drawing.Size(29, 13);
            this.lblHöjd.TabIndex = 6;
            this.lblHöjd.Text = "Höjd";
            // 
            // lbxFigur
            // 
            this.lbxFigur.FormattingEnabled = true;
            this.lbxFigur.Location = new System.Drawing.Point(387, 44);
            this.lbxFigur.Name = "lbxFigur";
            this.lbxFigur.Size = new System.Drawing.Size(179, 160);
            this.lbxFigur.TabIndex = 1;
            // 
            // lblFigurlista
            // 
            this.lblFigurlista.AutoSize = true;
            this.lblFigurlista.Location = new System.Drawing.Point(384, 28);
            this.lblFigurlista.Name = "lblFigurlista";
            this.lblFigurlista.Size = new System.Drawing.Size(48, 13);
            this.lblFigurlista.TabIndex = 7;
            this.lblFigurlista.Text = "Figurlista";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(384, 220);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(95, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Sammanlagd area:";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(387, 236);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(100, 20);
            this.tbxArea.TabIndex = 7;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(137, 233);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(100, 23);
            this.btnArea.TabIndex = 7;
            this.btnArea.Text = "Sammanlagd area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFigurlista);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.lbxFigur);
            this.Controls.Add(this.gbxSkapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSkapa.ResumeLayout(false);
            this.gbxSkapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSkapa;
        private System.Windows.Forms.Button btnLinje;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Button btnTriangel;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.Label lblHöjd;
        private System.Windows.Forms.Label lblBredd;
        private System.Windows.Forms.ListBox lbxFigur;
        private System.Windows.Forms.Label lblFigurlista;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Button btnArea;
    }
}

