namespace Övning2_3
{
    //INTE KLAR
    public partial class Form1 : Form
    {
        Bank bank = new Bank();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsättning_Click(object sender, EventArgs e)
        {
            double belopp;
            if (lbxList.SelectedItem != null)
            {
                if (!double.TryParse(tbxBelopp.Text, out belopp))
                {
                    MessageBox.Show("Ange ett giltigt belopp");
                    return;
                }
                (lbxList.SelectedItem as BankKonto).Insättning(belopp);



            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            string personNr;
            double räntesats;
            double kredit;
            personNr = tbxPersonNr.Text;

            if (!double.TryParse(tbxRäntesats.Text, out räntesats) || !double.TryParse(tbxKredit.Text, out kredit))
            {
                MessageBox.Show("Ange en giltig räntesats och kredit");
                return;
            }

            BankKonto nyttKonto;
            if (kredit == 0)
            {
                nyttKonto = new SparKonto(personNr, räntesats);
            }
            else
            {
                nyttKonto = new LåneKonto(personNr, räntesats, kredit);
            }


        }

        public void Uppdatera()
        {
            lbxList.Items.Clear();
            foreach()
        }
    }
}