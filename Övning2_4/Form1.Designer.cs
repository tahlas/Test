namespace Övning2_4
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
            gbxSkapa = new GroupBox();
            label1 = new Label();
            tbxBredd = new TextBox();
            tbxHöjd = new TextBox();
            label2 = new Label();
            btnTriangel = new Button();
            btnCirkel = new Button();
            btnLinje = new Button();
            lbxFigur = new ListBox();
            lblFigur = new Label();
            tbxArea = new TextBox();
            lblArea = new Label();
            btnArea = new Button();
            gbxSkapa.SuspendLayout();
            SuspendLayout();
            // 
            // gbxSkapa
            // 
            gbxSkapa.Controls.Add(btnLinje);
            gbxSkapa.Controls.Add(btnCirkel);
            gbxSkapa.Controls.Add(btnTriangel);
            gbxSkapa.Controls.Add(tbxHöjd);
            gbxSkapa.Controls.Add(label2);
            gbxSkapa.Controls.Add(tbxBredd);
            gbxSkapa.Controls.Add(label1);
            gbxSkapa.Location = new Point(73, 57);
            gbxSkapa.Name = "gbxSkapa";
            gbxSkapa.Size = new Size(294, 203);
            gbxSkapa.TabIndex = 0;
            gbxSkapa.TabStop = false;
            gbxSkapa.Text = "Skapa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Bredd";
            // 
            // tbxBredd
            // 
            tbxBredd.Location = new Point(74, 22);
            tbxBredd.Name = "tbxBredd";
            tbxBredd.Size = new Size(100, 23);
            tbxBredd.TabIndex = 1;
            // 
            // tbxHöjd
            // 
            tbxHöjd.Location = new Point(74, 66);
            tbxHöjd.Name = "tbxHöjd";
            tbxHöjd.Size = new Size(100, 23);
            tbxHöjd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Höjd";
            // 
            // btnTriangel
            // 
            btnTriangel.Location = new Point(74, 95);
            btnTriangel.Name = "btnTriangel";
            btnTriangel.Size = new Size(100, 23);
            btnTriangel.TabIndex = 4;
            btnTriangel.Text = "Skapa Triangel";
            btnTriangel.UseVisualStyleBackColor = true;
            btnTriangel.Click += btnTriangel_Click;
            // 
            // btnCirkel
            // 
            btnCirkel.Location = new Point(74, 124);
            btnCirkel.Name = "btnCirkel";
            btnCirkel.Size = new Size(100, 23);
            btnCirkel.TabIndex = 5;
            btnCirkel.Text = "Skapa Cirkel";
            btnCirkel.UseVisualStyleBackColor = true;
            btnCirkel.Click += btnCirkel_Click;
            // 
            // btnLinje
            // 
            btnLinje.Location = new Point(74, 153);
            btnLinje.Name = "btnLinje";
            btnLinje.Size = new Size(100, 23);
            btnLinje.TabIndex = 6;
            btnLinje.Text = "Skapa Linje";
            btnLinje.UseVisualStyleBackColor = true;
            btnLinje.Click += btnLinje_Click;
            // 
            // lbxFigur
            // 
            lbxFigur.FormattingEnabled = true;
            lbxFigur.ItemHeight = 15;
            lbxFigur.Location = new Point(389, 57);
            lbxFigur.Name = "lbxFigur";
            lbxFigur.Size = new Size(211, 199);
            lbxFigur.TabIndex = 1;
            // 
            // lblFigur
            // 
            lblFigur.AutoSize = true;
            lblFigur.Location = new Point(389, 39);
            lblFigur.Name = "lblFigur";
            lblFigur.Size = new Size(55, 15);
            lblFigur.TabIndex = 7;
            lblFigur.Text = "Figurlista";
            // 
            // tbxArea
            // 
            tbxArea.Location = new Point(420, 289);
            tbxArea.Name = "tbxArea";
            tbxArea.Size = new Size(100, 23);
            tbxArea.TabIndex = 8;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(418, 271);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(102, 15);
            lblArea.TabIndex = 7;
            lblArea.Text = "Sammanlagd area";
            // 
            // btnArea
            // 
            btnArea.Location = new Point(130, 288);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(154, 23);
            btnArea.TabIndex = 7;
            btnArea.Text = "Sammanlagd area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnArea);
            Controls.Add(tbxArea);
            Controls.Add(lblArea);
            Controls.Add(lblFigur);
            Controls.Add(lbxFigur);
            Controls.Add(gbxSkapa);
            Name = "Form1";
            Text = "Form1";
            gbxSkapa.ResumeLayout(false);
            gbxSkapa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxSkapa;
        private Button btnLinje;
        private Button btnCirkel;
        private Button btnTriangel;
        private TextBox tbxHöjd;
        private Label label2;
        private TextBox tbxBredd;
        private Label label1;
        private ListBox lbxFigur;
        private Label lblFigur;
        private TextBox tbxArea;
        private Label lblArea;
        private Button btnArea;
    }
}