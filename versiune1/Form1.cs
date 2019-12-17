using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace versiune1
{

    public partial class Main_Form : Form
    {
        FunctiDB functie = new FunctiDB();
        public Main_Form()
        {
            InitializeComponent();
            Afisare();
           
        }
      
      public  void Afisare()
        {
            tabel_afisare.Rows.Clear();

                var Angajatii = functie.GetAllAngajat();
                foreach (Angajat ang in Angajatii)
                {
                tabel_afisare.Rows.Add(ang.Nume , ang.Prenume , ang.Data_nasteri , ang.Data_Angajari,ang.Salariu,"" ,"" , ang.Id);
                }          
        }
           
      
        private void Export_button_Click(object sender, EventArgs e)
        {
            export Form_edit = new export();
            Form_edit.Show();
        }
       
    
       
      

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Afisare();
        }

        private void Angajat_nou_button_Click(object sender, EventArgs e)
        {
           // this.Visible = false;
            Nou_Angajat Form_new = new Nou_Angajat();
            Form_new.Show();
        }


   

   

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==5)
            {
                DataGridViewRow selectRow = tabel_afisare.Rows[e.RowIndex];
                int id_angajat = int.Parse(selectRow.Cells[7].Value.ToString());
                Editare_Angajat Form_edit = new Editare_Angajat(id_angajat);
               Form_edit.Show();
               
            }
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow selectRow = tabel_afisare.Rows[e.RowIndex];
                int id_angajat = int.Parse(selectRow.Cells[7].Value.ToString());
                functie.StergeAngajat(id_angajat);
                Afisare();
            }
        }
    }
}
