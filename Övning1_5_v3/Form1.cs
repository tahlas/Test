using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning1_5_v3
{
    public partial class Form1 : Form
    {
        List<Fordon> fordona = new List<Fordon>();
        
        public Form1()
        {
            InitializeComponent();
            cbxTyp.SelectedIndex = 0;
            rbnAlla.Select();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            try
            {
                string regNr = Fordon.GodkännRegNr(tbxRegNr.Text);
                //if(regNr == null)
                //{
                //    MessageBox.Show("Registreringsnummer måste vara på formen ABC123");
                //    return;
                //}
                foreach (Fordon f in fordona)
                {
                    if (f.RegNr == regNr)
                    {
                        MessageBox.Show("Registreringsnummer finns redan!");
                        return;
                    }

                }

                Fordon nyFordon = new Fordon(regNr, tbxMärke.Text, tbxModell.Text, (Fordon.Typ)cbxTyp.SelectedIndex);
                fordona.Add(nyFordon);
                lbxRegister.Items.Add(nyFordon);
            }
            catch(FelFormatException error)
            {
                MessageBox.Show(error.ToString());
            }

            


        }

        private void rbnBilar_CheckedChanged(object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach (Fordon f in fordona)
            {
                if(f.FordonsTyp == Fordon.Typ.Bil)
                {
                    lbxRegister.Items.Add(f);
                }
            }
        }

        private void rbnMC_CheckedChanged(object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach(Fordon f in fordona)
            {
                if(f.FordonsTyp == Fordon.Typ.MC)
                {
                    lbxRegister.Items.Add(f);
                }
            }
        }

        private void rbnAlla_CheckedChanged(object sender, EventArgs e)
        {
            lbxRegister.Items.Clear();

            foreach (Fordon f in fordona)
            {
                    lbxRegister.Items.Add(f);
            }
        }
    }
}
