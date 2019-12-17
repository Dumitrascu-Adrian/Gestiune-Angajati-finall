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
    public partial class Nou_Angajat : Form
    {
        FunctiDB functii = new FunctiDB();
        public Nou_Angajat()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
           
                var ang = new Angajat()
                {
                    Nume = textBox_nume.Text,
                    Prenume = textBox_prenume.Text,
                   
                    Data_Angajari = textBox_dataangajari.Text,
                    Data_nasteri = textBoxData_nasteri.Text,
                    Salariu = int.Parse(textBox_salariu.Text)
                    
                };
           
            functii.Insert(ang);
            this.Close();

          
        }
    }
}
