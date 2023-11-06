namespace InförProvARV
{
    public partial class Form1 : Form //Lägg till Dokumentation! XML
                                      //Ändra kanske till enum?
                                      //Rensar alla textboxes i groupbox
    {
        List<Media> mediaList = new List<Media>();
        public Form1()
        {
            InitializeComponent();
            rbnBok.Select(); //förväljer typ Bok
        }

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxUtgivningsÅr.Text, out int utgivningsÅr))
            {
                MessageBox.Show("Ange ett giltigt utgivnings år");
                return;
            }
            if (!int.TryParse(tbxPris.Text, out int pris))
            {
                MessageBox.Show("Ange ett giltigt pris");
                return;
            }


            if (rbnBok.Checked)
            {
                if (!int.TryParse(tbxSidorLängd.Text, out int sidor))
                {
                    MessageBox.Show("Ange ett giltigt antal sidor");
                    return;
                }

                Bok nyBok = new Bok(tbxTitel.Text, utgivningsÅr, pris, sidor, tbxFörfattareArtist.Text);
                mediaList.Add(nyBok);
                lbxLista.Items.Add(nyBok);

            }
            else //om rbnCD.Checked
            {
                if (!int.TryParse(tbxSidorLängd.Text, out int längd))
                {
                    MessageBox.Show("Ange en giltig längd");
                    return;
                }
                if (!int.TryParse(tbxAntalLåtar.Text, out int antalLåtar))
                {
                    MessageBox.Show("Ange ett giltigt antal låtar");
                }

                CD nyCD = new CD(tbxTitel.Text, utgivningsÅr, pris, längd, tbxFörfattareArtist.Text, antalLåtar);
                mediaList.Add(nyCD);
                lbxLista.Items.Add(nyCD);
            }

            foreach(Control control in gbxLäggTill.Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Clear();

                    //ELLER
                    //TextBox textBox = (TextBox)control;
                    //textBox.Clear();
                }
            }

        }

        private void btnÄndra_Click(object sender, EventArgs e) //Kanske borde döpa till ny istället för 2
        {
            if (lbxLista.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en artikel i listan");
                return;
            }
            int index = lbxLista.SelectedIndex;

            string titel;
            int utgivningsÅr;
            int pris;
            int sidor;
            int längd;
            int antalLåtar;
            string författareArtist;

            if (tbxUtgivningsÅr2.Text == "")
            {
                utgivningsÅr = mediaList[index].UtgivningsÅr;
            }
            else if (!int.TryParse(tbxUtgivningsÅr2.Text, out utgivningsÅr))
            {
                MessageBox.Show("Ange ett giltigt utgivnings år");
                return;
            }

            if (tbxPris2.Text == "")
            {
                pris = mediaList[index].Pris;
            }
            else if (!int.TryParse(tbxPris2.Text, out pris))
            {
                MessageBox.Show("Ange ett giltigt pris");
                return;
            }
            if (tbxTitel2.Text == "")
            {
                titel = mediaList[index].Titel;
            }
            else
            {
                titel = tbxTitel2.Text;
            }


            if (mediaList[index] is Bok)
            {
                //Se sida 62 i boken
                Bok bok = (Bok)mediaList[index];
                if (tbxSidorLängd2.Text == "")
                {

                    sidor = bok.Sidor;
                }
                else if (!int.TryParse(tbxSidorLängd2.Text, out sidor))
                {
                    MessageBox.Show("Ange ett giltigt antal sidor");
                    return;
                }

                if (tbxFörfattareArtist2.Text == "")
                {
                    författareArtist = bok.Författare;
                }
                else
                {
                    författareArtist = tbxFörfattareArtist2.Text;
                }
                Bok nyBok = new Bok(titel, utgivningsÅr, pris, sidor, författareArtist);
                mediaList[index] = nyBok;
                lbxLista.Items[index] = nyBok;
            }
            else
            {
                CD cd = (CD)mediaList[index];
                if (tbxSidorLängd2.Text == "")
                {
                    //CD cd = (CD)mediaList[index];
                    längd = cd.Längd;

                }
                else if (!int.TryParse(tbxSidorLängd2.Text, out längd))
                {
                    MessageBox.Show("Ange en giltig längd");
                    return;
                }
                if (tbxAntalLåtar2.Text == "")
                {
                    //CD cd = (CD)mediaList[index];
                    antalLåtar = cd.AntalLåtar;
                }
                else if (!int.TryParse(tbxAntalLåtar2.Text, out antalLåtar))
                {
                    MessageBox.Show("Ange ett giltigt antal låtar");
                }

                if (tbxFörfattareArtist2.Text == "")
                {
                    författareArtist = cd.Artist;
                }
                else
                {
                    författareArtist = tbxFörfattareArtist2.Text;
                }

                CD nyCD = new CD(titel, utgivningsÅr, pris, längd, författareArtist, antalLåtar);
                mediaList[index] = nyCD;
                lbxLista.Items[index] = nyCD;
            }

            //rensa alla textboxes i groupbox
            foreach(Control control in gbxÄndra.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }

        }

        private void btnSorteraPris_Click(object sender, EventArgs e)
        {
            mediaList.Sort();

            lbxLista.Items.Clear();

            foreach (Media media in mediaList)
            {
                lbxLista.Items.Add(media);
            }
        }

        //public void Sortera()
        //{
        //    lbxLista.Items.Clear();
        //    foreach (Media media in mediaList)
        //    {
        //        lbxLista.Items.Add(media);
        //    }
        //}
    }
}