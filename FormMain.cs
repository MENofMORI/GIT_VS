using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private string rola;

        List<Data> DATA;
        List <Kategoria> KATEGORIE;
        public string Rola { get => rola; set => rola = value; }
        
        public FormMain()
        {
            InitializeComponent();
            //Form1 f12 = new Form1(this);
            //f12.ShowDialog();

            DATA.Add(new Data(0, "Drukarka pentagon ", "Same kwadraty", (float)519.99, 3, 31));
            DATA.Add(new Data(1, "Drukarka Hb ", "Drukuje dobrze", (float)334.99, 3, 32));
            DATA.Add(new Data(2, "SPC Fortuna", "Chłodzi jak woda w południe", (float)19.99, 2, 21));
            DATA.Add(new Data(3, "Myszka", "Myszka ale nie Miki", (float)119.99, 1, 11));
            DATA.Add(new Data(4, "Myszka-ergo", "Myszka wygodna jak kanapa po robocie", (float)249.99, 1, 11));

            KATEGORIE = new List<Kategoria>();

            KATEGORIE.Add(new Kategoria(0, "Wszystko"));
            KATEGORIE.Add(new Kategoria(1, "Peryferia"));
            KATEGORIE.Add(new Kategoria(2, "Chlodzenia"));
            KATEGORIE.Add(new Kategoria(3, "Drukarki"));
            KATEGORIE.Add(new Kategoria(11, "Myszki"));
            KATEGORIE.Add(new Kategoria(12, "Klawiatury"));
            KATEGORIE.Add(new Kategoria(13, "Gamepady"));
            KATEGORIE.Add(new Kategoria(21, "Chlodzenia powietrzne"));
            KATEGORIE.Add(new Kategoria(22, "Ciekly Azot"));
            KATEGORIE.Add(new Kategoria(31, "Laserowa"));
            KATEGORIE.Add(new Kategoria(32, "Atramentowa"));

            KATEGORIE[0].addPotkategia(KATEGORIE[1].IdKategori);
            KATEGORIE[0].addPotkategia(KATEGORIE[2].IdKategori);
            KATEGORIE[0].addPotkategia(KATEGORIE[3].IdKategori);

            KATEGORIE[1].addPotkategia(KATEGORIE[4].IdKategori);
            KATEGORIE[1].addPotkategia(KATEGORIE[5].IdKategori);
            KATEGORIE[1].addPotkategia(KATEGORIE[6].IdKategori);

            KATEGORIE[2].addPotkategia(KATEGORIE[7].IdKategori);
            KATEGORIE[2].addPotkategia(KATEGORIE[8].IdKategori);

            KATEGORIE[3].addPotkategia(KATEGORIE[9].IdKategori);
            KATEGORIE[3].addPotkategia(KATEGORIE[10].IdKategori);




            odblokujPanelToolStripMenuItem_Click(this, null);
            toolStripStatusLabel.Text = "";
        }

        private void daneToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Opcaja umożliwia dodanie danych do aplikacji";
        }

        private void daneToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            clearToolStripStatusLabel();
        }
        
        private void usunDaneToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Opcaja umożliwia usuwanie danych do aplikacji";
        }

        private void usunDaneToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            clearToolStripStatusLabel();
        }

        private void wyszukajDaneToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Opcaja umożliwia wyszukiwanie danych w bazie";
        }

        private void wyszukajDaneToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            clearToolStripStatusLabel();
        }

        private void clearToolStripStatusLabel()
        {
            toolStripStatusLabel.Text = "Brak podpowiedzi - najedź na coś";
        }

        private void zablokujPanelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.menuStrip.Enabled = false;
            this.zablokujPanelToolStripMenuItem1.Enabled = false;
            this.odblokujPanelToolStripMenuItem.Enabled = true;
            toolStripStatusLabel.Text = "Pasek Menu zablokowany - klkinij PPM i wybierz odblokuj w menu kntekstowym !";
            toolStripStatusLabel.ForeColor = Color.Red;
        }

        private void odblokujPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip.Enabled = true;
            this.zablokujPanelToolStripMenuItem1.Enabled = true;
            this.odblokujPanelToolStripMenuItem.Enabled = false;
            toolStripStatusLabel.Text = "Pasek Menu odblokowany !";
            toolStripStatusLabel.ForeColor = Color.Black;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Czy chcesz odświeżyć Dane ? /n Może to chilę potrwać.","",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                FormLoading formLoading = new FormLoading(10);
            }
        }
        private void daneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wyszukajDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(0,);
        }

        private void usuńDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}