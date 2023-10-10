using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InförPraktik_Uppgift1
{
    public partial class Form1 : Form
    {
        List<Kort> k = new List<Kort>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLägg_Click(object sender, EventArgs e)
        {
            string färg = tbxFärg.Text;
            string valör = tbxValör.Text;
            if (färg == "" || valör == "")
            {
                MessageBox.Show("Ange en giltig färg och valör"); return;
            }
            Kort nyKort = new Kort(färg, valör);
            k.Add(nyKort);
            lbxKort.Items.Add(nyKort);
            tbxFärg.Clear();
            tbxValör.Clear();
        }

        private void tbxTaBort_Click(object sender, EventArgs e)
        {
            string färg = tbxFärg.Text;
            string valör = tbxValör.Text;
            bool kortFinns = false;
            int i = 0;
            while (i<k.Count)
            {
                if (k[i].Färg == färg && k[i].Valör == valör)
                {
                    lbxKort.Items.Remove(k[i]);
                    k.Remove(k[i]);
                    kortFinns = true;
                }
                else //fortsätter med index som kommer efter bara då vi vet att k[i] inte finns
                {
                    i++;
                }
            }
            if(!kortFinns)
            {
                MessageBox.Show("Kortet finns ej");
            }

            tbxFärg.Clear();
            tbxValör.Clear();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<k.Count-1;i++) //k.Count-1 eftersom vi har redan kontrollerat ifall det sista kortet är par med något annat
            {
                for(int n = 0;n<k.Count;n++)
                {
                    if (k[i].Valör == k[n].Valör && i!=n)
                    {
                        tbxPar.Text = "Det finns ett par (" + k[i].Valör + ")";
                    }
                }
                
            }
        }
    }
}
