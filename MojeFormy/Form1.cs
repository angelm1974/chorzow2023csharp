namespace MojeFormy
{
    public partial class Form1 : Form
    {
        List<string> osoby = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DeepPink;
            osoby.Add("Janek Kowalski");
            osoby.Add("Adam Borok");
            osoby.Add("Ola Nowak");
            listBox1.DataSource = osoby;
        }


        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void klikniecie(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zmien_kolor_tla(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("Twoje imiê to: {0}, a nazwisko to : {1}", txtImie.Text, txtNazwisko.Text));
            dodajElement(string.Format("{0} {1}", txtImie.Text, txtNazwisko.Text));
        }

        private void dodajElement(string imieNazwisko)
        {
            osoby.Add(imieNazwisko);
            odswiez();
        }

        private void odswiez()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = osoby;
        }

    }
}