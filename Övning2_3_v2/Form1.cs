using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning2_3_v2
{
    public partial class Form1 : Form
    {
        Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnInsättning_Click(object sender, EventArgs e)
        {
            if(lbxLista.SelectedItem != null)
            {
                if (!double.TryParse(tbxBelopp.Text, out double belopp))
                {
                    MessageBox.Show("Ange ett giltigt belopp");
                }
                (lbxLista.SelectedItem as BankKonto).Insättning(belopp);
                Uppdatera();
                BehållningBank();
            }
            RensaTextBox(gbxInsättningUttag);
        }

        private void btnUttag_Click(object sender, EventArgs e)
        {
            if (lbxLista.SelectedItem != null)
            {
                if (!double.TryParse(tbxBelopp.Text, out double belopp))
                {
                    MessageBox.Show("Ange ett giltigt belopp");
                    return;
                }

                if((lbxLista.SelectedItem as BankKonto).Uttag(belopp) == false)
                {
                    MessageBox.Show("Medges ej");
                }
                else
                {
                    Uppdatera();
                    BehållningBank();
                }
            }
            RensaTextBox(gbxInsättningUttag);
        }
        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if((tbxPersonNr.Text).Length!=10||!int.TryParse(tbxPersonNr.Text, out int personNr))
            {
                MessageBox.Show("Ange ett giltigt personnummer på formen ÅÅMMDDNNNN");
                return;
            }
            
            if(!double.TryParse(tbxRäntesats.Text, out double ränteSats))
            {
                MessageBox.Show("Ange en giltig räntesats");
                return;
            }
            if(!double.TryParse(tbxKredit.Text, out double kredit))
            {
                MessageBox.Show("Ange en giltig kredit");
                return;
            }
            BankKonto nyttKonto;
            if(kredit == 0)
            {
                nyttKonto = new SparKonto(tbxPersonNr.Text, ränteSats);
            }
            else
            {
                nyttKonto = new Lånekonto(tbxPersonNr.Text,ränteSats,kredit);
            }
            bank.Konton.Add(nyttKonto);
            Uppdatera();
            BehållningBank();
            RensaTextBox(gbxÖppnaKonto);
        }
        private void btnÅrsränta_Click(object sender, EventArgs e)
        {
            foreach(BankKonto konto in bank.Konton)
            {
                konto.BeräknaRänta();
            }

            Uppdatera();
            BehållningBank();
        }
        private void Uppdatera()
        {
            lbxLista.Items.Clear();
            foreach (BankKonto konto in bank.Konton)
            {
                lbxLista.Items.Add(konto);
            }
        }
        private void BehållningBank()
        {
            double behållningBank = 0;
            foreach(BankKonto konto in bank.Konton)
            {
                behållningBank+=konto.Behållning;
            }
            tbxBehållningBank.Text = behållningBank.ToString();
        }
        private void RensaTextBox(GroupBox groupBox)
        {
            foreach(Control control in groupBox.Controls)
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
