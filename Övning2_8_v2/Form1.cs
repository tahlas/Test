using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning2_8_v2
{
    public partial class Form1 : Form
    {
        List<Vara> varaList = new List<Vara>();
        public Form1()      
        {
            InitializeComponent();
            rbnLösvikt.Checked = true;
        }
        //LÄGG TILL XML!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btnLägg_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(tbxPris.Text, out double pris)) //pris per kg eller pris per styck
            {
                MessageBox.Show("Ange ett giltigt pris");
                return;
            }

            if(rbnLösvikt.Checked)
            {
                if(!double.TryParse(tbxMängd.Text, out double kilopris)) //pris per kg
                {
                    MessageBox.Show("Ange ett giltigt kilopris");
                    return;
                }

                LösVikt nyLösvikt = new LösVikt(tbxVara.Text, pris, kilopris);
                varaList.Add(nyLösvikt);
                lbxVara.Items.Add(nyLösvikt);
            }
            else
            {
                if (rbnStycksak.Checked)
                {
                    if(!int.TryParse(tbxMängd.Text, out int antal)) //antalet av en viss vara
                    {
                        MessageBox.Show("Ange ett giltigt antal");
                        return;
                    }
                    StyckSak nyStyckSak = new StyckSak(tbxVara.Text, pris, antal);
                    varaList.Add(nyStyckSak);
                    lbxVara.Items.Add(nyStyckSak);

                }
            }

            foreach(Control control in gbxLägg.Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Clear();

                    //eller
                    //TextBox textBox = (TextBox)control;
                    //textBox.Clear();
                }
            }

            double summa = 0;
            foreach(Vara vara in varaList)
            {
                summa += vara.BeräknaPris();
            }
            tbxSumma.Text = Math.Round(summa,0).ToString();
        }

        private void btnSorteraPris_Click(object sender, EventArgs e)
        {
            varaList.Sort();
            lbxVara.Items.Clear();
            foreach(Vara vara in varaList)
            {
                lbxVara.Items.Add(vara);
            }
            
        }
    }

    
}
