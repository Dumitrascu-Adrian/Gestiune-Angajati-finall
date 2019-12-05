using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versiune1
{
    public partial class Editare_Angajat : Form
    {
        int id;
        FunctiDB functie = new FunctiDB();
        public Editare_Angajat(int id)
        {
            this.id = id;
            InitializeComponent();
            EditareAngajat();
           
        }
   
     
        private void Update_button_Click(object sender, EventArgs e)
        {
            UpdateAngajat();
        }

        void UpdateAngajat()
        {
            Angajat angajat = new Angajat();
            angajat.Nume = textBox_nume.Text;
            angajat.Prenume = textBox_prenume.Text;
            angajat.Data_Angajari = textBox_dataangajari.Text;
            angajat.Data_nasteri = textBoxData_nasteri.Text;
            angajat.Salariu = int.Parse(textBox_salariu.Text);

            functie.Update(id, angajat);

            this.Close();
        }
        void EditareAngajat()
        {
            Angajat angajat=  functie.GetAngajat(id);
            textBox_nume.Text = angajat.Nume;
            textBox_prenume.Text = angajat.Prenume;
            textBox_dataangajari.Text = angajat.Data_Angajari;
            textBoxData_nasteri.Text = angajat.Data_nasteri;
            textBox_salariu.Text = angajat.Salariu.ToString();
        }
        

    }
}
