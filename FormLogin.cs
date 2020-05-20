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
    public partial class Form1 : Form
    {
        string[] role = new string[] { "Rola_1", "Rola_2", "Rola_3" };
        FormMain fm;

        public Form1(FormMain fm)
        {
            this.fm = fm;
            InitializeComponent();
            Form1_Load();
        }

        private void zaloguj_button_Click(object sender, EventArgs e)
        {
            if(this.login_textBox.Text=="admin" && this.haslo_textBox.Text == "123")
            {
                fm.Rola = role_comboBox.SelectedItem.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd logowania", "Uwaga");
            }
        }


        private void Form1_Load(){
            this.role_comboBox.Items.AddRange(role);
            this.zaloguj_button.Enabled = false;
        }

        private void OdblokujLogowanie(){
            if(this.login_textBox.Text != "" && this.haslo_textBox.Text != "" && this.role_comboBox.SelectedIndex >= 1){
                this.zaloguj_button.Enabled = true;
            }
            else{
                this.zaloguj_button.Enabled = false;
            }
        }

        private void login_textBox_TextChanged(object sender, EventArgs e){
            OdblokujLogowanie();
        }

        private void haslo_textBox_TextChanged(object sender, EventArgs e){
            OdblokujLogowanie();
        }

        private void role_comboBox_SelectedIndexChanged(object sender, EventArgs e){
            OdblokujLogowanie();
        }
    }
}
