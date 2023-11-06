using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning2_4_v2
{
    public partial class Form1 : Form
    {
        double area = 0;
        double bredd;
        double höjd;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTriangel_Click(object sender, EventArgs e)
        {
            KontrolleraInput();
            Triangel triangel = new Triangel(bredd, höjd);
            area += triangel.Area();
            lbxFigur.Items.Add(triangel);
            RensaGbxTextBoxes();
        }
        private void btnCirkel_Click(object sender, EventArgs e)
        {
            KontrolleraInput();
            Cirkel cirkel = new Cirkel(bredd, höjd);
            area += cirkel.Area();
            lbxFigur.Items.Add(cirkel);
            RensaGbxTextBoxes();
        }
        private void btnLinje_Click(object sender, EventArgs e)
        {
            KontrolleraInput();
            Linje linje = new Linje(bredd, höjd);
            lbxFigur.Items.Add(linje);
            RensaGbxTextBoxes();
        }
        private void btnArea_Click(object sender, EventArgs e)
        {
            tbxArea.Text = Math.Round(area, 0) + " a.e.";

        }
        public void KontrolleraInput()
        {
            if (!double.TryParse(tbxBredd.Text, out bredd))
            {
                MessageBox.Show("Ange en giltig bredd");
                return;
            }
            if (!double.TryParse(tbxHöjd.Text, out höjd))
            {
                MessageBox.Show("Ange en giltig höjd");
                return;
            }
        }

        public void RensaGbxTextBoxes()
        {
            foreach(Control control in  gbxSkapa.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }
    }
}
