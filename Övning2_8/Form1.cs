namespace Övning2_8
{
    public partial class Form1 : Form
    {
        List<Vara> varaList = new List<Vara>();

        double summa = 0;

        public Form1()
        {
            InitializeComponent();
            rbnLösvikt.Select();
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            //if(!int.TryParse(tbxMängd.Text, out int antal)&&!double.TryParse(tbxMängd.Text, out double vikt))
            //{
            //    MessageBox.Show("Ange en giltig mängd");
            //    return;
            //}

            double pris;

            if (!double.TryParse(tbxPris.Text, out pris))
            {
                MessageBox.Show("Ange ett giltigt pris");
                return;
            }

            //Måste fixa så att pris bestämts från klassen
            if (rbnLösvikt.Checked)
            {
                double vikt;
                if (!double.TryParse(tbxMängd.Text, out vikt))
                {
                    MessageBox.Show("Ange en giltig mängd (ange en double)");
                    return;
                }

                LösVikt nyLös = new LösVikt(tbxVara.Text, pris, double.Parse(tbxMängd.Text));
                varaList.Add(nyLös);
                //lbxVaruLista.Items.Add(nyLös + "\r\n \t" + nyLös.BeräknaPris() + " kr");
                lbxVaruLista.Items.Add(nyLös);
                summa += nyLös.BeräknaPris();


            }
            else
            {
                int antal;
                if (!int.TryParse(tbxMängd.Text, out antal))
                {
                    MessageBox.Show("Ange en giltig mängd (ange en int)");
                    return;
                }

                StyckSak nyStyck = new StyckSak(tbxVara.Text, pris, int.Parse(tbxMängd.Text));
                varaList.Add(nyStyck);
                //lbxVaruLista.Items.Add(nyStyck + "\r\n \t " + nyStyck.BeräknaPris() + " kr");
                lbxVaruLista.Items.Add(nyStyck);
                summa += nyStyck.BeräknaPris();
            }
            tbxSumma.Text = summa.ToString();

            tbxVara.Clear();
            tbxPris.Clear();
            tbxMängd.Clear();
        }

        private void btnSorteraPris_Click(object sender, EventArgs e)
        {
            varaList.Sort();

            lbxVaruLista.Items.Clear();

            foreach(Vara vara in varaList)
            {
                lbxVaruLista.Items.Add(vara);
            }
            

            
        }

        private void tbxSorteraNamn_Click(object sender, EventArgs e)
        {
            //varaList.Sort();

            //lbxVaruLista.Items.Clear();

            //foreach(Vara vara in varaList)
            //{
            //    lbxVaruLista.Items.Add(vara);
            //}
        }
    }
}