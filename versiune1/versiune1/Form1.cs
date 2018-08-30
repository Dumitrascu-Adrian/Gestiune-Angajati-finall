using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace versiune1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Afisare();
        }
        String AfisareSpati(String str)
        {
            String spati = "";
            int x = str.Length;
            for (int i=x;i<20;i++)
            {
                spati = spati + " ";
            }
            return spati;
        }
      public  void Afisare()
        {
            ListaAngajati.Items.Clear();
            ListaAngajati.Items.Add("Id" + " " + "Nume" + AfisareSpati("Nume") + "Prenume" + "    " + "Data nasteri" + "     " + "Angajarat" + "     " +"Salariu");

            using (var context = new EmployeeEntities())
            {
                var query = from st in context.Angajats

                            select st;

                var student = context.Angajats.ToList();
                foreach (Angajat ang in student)
                {
                    ListaAngajati.Items.Add(ang.Id + " " + ang.Nume + AfisareSpati(ang.Nume) + ang.Prenume + AfisareSpati(ang.Prenume) + ang.Data_nasteri + "     " + ang.Data_Angajari + "     " + ang.Salariu);
                }
            }
        }
           
      
        private void Export_button_Click(object sender, EventArgs e)
        {
            export Form_edit = new export();
            Form_edit.Show();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            string[] words = ListaAngajati.Items[ListaAngajati.SelectedIndex].ToString().Split(' ');
            int indice = int.Parse(words[0]);
            Editare_Angajat Form_edit = new Editare_Angajat(indice);

            this.Visible = false;
            Form_edit.Show();
        
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            
            string[] words = ListaAngajati.Items[ListaAngajati.SelectedIndex].ToString().Split(' ');
            int indice = int.Parse(words[0]);
             using (var context = new EmployeeEntities())
              {
                  var std = context.Angajats.Where(s=>s.Id== indice).First<Angajat>();
                  context.Angajats.Remove(std);

                  context.SaveChanges();
              }
            Afisare();
        }

        private void exit_button_Click(object sender, EventArgs e) => this.Close();

        private void Angajat_nou_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Nou_Angajat Form_new = new Nou_Angajat();
            Form_new.Show();
        }
    }
}
