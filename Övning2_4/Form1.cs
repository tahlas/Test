namespace Övning2_4
{
    public partial class Form1 : Form
    {
        List<Figur> figurer = new List<Figur>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriangel_Click(object sender, EventArgs e)
        {
            int bredd;
            bool breddOK = int.TryParse(tbxBredd.Text, out bredd);
            if(!breddOK)
            {
                MessageBox.Show("Skriv ett tal");
                return;
            }
            int höjd;
            bool höjdOK = int.TryParse(tbxHöjd.Text, out höjd);
            if(!höjdOK)
            {
                MessageBox.Show("Skriv ett tal");
                return;
            }

            Triangel triangel = new Triangel(bredd, höjd);
            figurer.Add(triangel);
            lbxFigur.Items.Add(triangel);
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            int bredd;
            bool breddOK = int.TryParse(tbxBredd.Text, out bredd);
            if (!breddOK)
            {
                MessageBox.Show("Skriv ett tal");
                return;
            }
            //int höjd;
            //bool höjdOK = int.TryParse(tbxHöjd.Text, out höjd);
            //if (!höjdOK)
            //{
            //    MessageBox.Show("Skriv ett tal");
            //    return;
            //}

            Cirkel cirkel = new Cirkel(bredd);
            figurer.Add(cirkel);
            lbxFigur.Items.Add(cirkel);
        }

        private void btnLinje_Click(object sender, EventArgs e)
        {
            int bredd;
            bool breddOK = int.TryParse(tbxBredd.Text, out bredd);
            if (!breddOK)
            {
                MessageBox.Show("Skriv ett tal");
                return;
            }
            int höjd;
            bool höjdOK = int.TryParse(tbxHöjd.Text, out höjd);
            if (!höjdOK)
            {
                MessageBox.Show("Skriv ett tal");
                return;
            }

            Linje linje= new Linje(bredd, höjd);
            figurer.Add(linje);
            lbxFigur.Items.Add(linje);
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double area = 0;
            foreach(Figur figur in figurer)
            {
                if(figur is IArea)
                {
                    area += (figur as IArea).Area();
                }
            }

            tbxArea.Text = Math.Round(area, 2) + " cm^2"; //Avrundar till 2 decimaler
        }
    }
}