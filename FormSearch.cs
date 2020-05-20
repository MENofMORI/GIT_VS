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
    public partial class FormSearch : Form
    {
        private int IdProdoktu;
        private String nazwa;
        private String opis;
        private float cena;
        private int sztuki;
        private int kategoria;

        Data data;

        bool walidacja;
        public bool Walidacja { get => walidacja; set => walidacja = value; }
        internal Data Data { get => data; set => data = value; }

        public FormSearch(bool Walidacja, Kategoria kategoria)
        {
            this.Walidacja = Walidacja;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetColorBoxes();
            GetDateFromBoxes();
        }

        private void ResetColorBoxes()
        {
            textBoxID.BackColor = Color.White;
            textBoxName.BackColor = Color.White;
            textBoxOpis.BackColor = Color.White;
            textBoxCena.BackColor = Color.White;
            textBoxSztuki.BackColor = Color.White;
            comboBox1.BackColor = Color.White;
        }

        private void GetDateFromBoxes()
        {
            IdProdoktu = IntZTextBoxa(textBoxID);
            nazwa = StringZTextBoxa(textBoxName);
            opis = StringZTextBoxa(textBoxOpis);
            cena = FloatZTextBoxa(textBoxCena);
            sztuki = IntZTextBoxa(textBoxSztuki);
            kategoria = IntZComboBoxa(comboBox1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public int IntZTextBoxa(TextBox value)
        {
            int rezultat;

            if (int.TryParse(value.Text.ToString(), out rezultat))
            {
                value.BackColor = Color.White;
                return rezultat;
            }
            else
            {
                value.BackColor = Color.Red;
                return 0;
            }
        }

        public float FloatZTextBoxa(TextBox value)
        {
            float rezultat;

            if (float.TryParse(value.Text.ToString(), out rezultat))
            {
                value.BackColor = Color.White;
                return rezultat;
            }
            else
            {
                value.BackColor = Color.Red;
                return 0;
            }

        }

        public string StringZTextBoxa(TextBox value)
        {
            string rezultat;

            if (value.Text.Length > 0)
            {
                value.BackColor = Color.White;
                rezultat = value.Text;
                return rezultat;
            }
            else
            {
                value.BackColor = Color.Red;
                return "";
            }

        }
    
        private int IntZComboBoxa(ComboBox comboBox1)
        {
            throw new NotImplementedException();
        }
    }
}
