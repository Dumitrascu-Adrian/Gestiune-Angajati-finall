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
        public Editare_Angajat(int id)
        {
            InitializeComponent();
            using (var context = new EmployeeEntities())
            {
                var query = from st in context.Angajats

                            select st;

                var ang = context.Angajats.Where(s=>s.Id==id).FirstOrDefault<Angajat>();
                textBox_id.Text = id.ToString() ;
                textBox_nume.Text=ang.Nume;
                 textBox_prenume.Text=ang.Prenume;
                textBox_dataangajari.Text=ang.Data_Angajari;
              textBoxData_nasteri.Text=ang.Data_nasteri;
               textBox_salariu.Text=ang.Salariu.ToString();
            }
          //  Afisare();
        }


      
   

        private void Update_button_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_id.Text);
            using (var context = new EmployeeEntities())
            {
                
                var ang = context.Angajats.Where(s => s.Id == id ).FirstOrDefault<Angajat>();
                    ang.Nume = textBox_nume.Text;
                    ang.Prenume = textBox_prenume.Text;
                    ang.Data_Angajari = textBox_dataangajari.Text;
                    ang.Data_nasteri = textBoxData_nasteri.Text;
                    ang.Salariu = int.Parse(textBox_salariu.Text);
                context.SaveChanges();
                
            }
            new Form1().Show();
            this.Close();
           
        }

       
    }
}
