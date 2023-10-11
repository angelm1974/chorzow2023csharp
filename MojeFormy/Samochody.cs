using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MojeFormy
{
    public partial class Samochody : Form
    {
        List<Samochod> mojeSamochody = new List<Samochod>();
        public Samochody()
        {
            InitializeComponent();
            samochodBindingSource.DataSource = mojeSamochody;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Samochod dodawany_samochod = new Samochod();
            dodawany_samochod.Marka = txtMarka.Text;
            dodawany_samochod.Model = txtModel.Text;
            dodawany_samochod.Kolor = cbKolor.Text;
            dodawany_samochod.Rocznik = nmRocznik.Value;


            samochodBindingSource.Add(dodawany_samochod);

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            samochodBindingSource.Remove(samochodBindingSource.Current);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
