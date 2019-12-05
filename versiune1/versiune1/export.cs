using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Web;
using System.Xml.Linq;

namespace versiune1
{
    public partial class export : Form
    {
        FunctiDB functie = new FunctiDB();
        public export()
        {
            InitializeComponent();
        }

        void ExportJSON()
        {
            var angajati = functie.GetAllAngajat();
            var jsonSerialiser = new System.Web.Script.Serialization.JavaScriptSerializer();
            string jsonString = jsonSerialiser.Serialize(angajati);
            File.WriteAllText(@"D:\AngajatiDB.json", jsonString);
            MessageBox.Show("Export reusit \n Fisierul se afla in D\n si are numele AngajatiDB.json");
        }

        void ExportXML()
        {
            DataSet ds = new DataSet();
            Angajat ang = new Angajat();
            DataTable dt = new DataTable();
            ang.GetType().GetProperties().ToList().ForEach(f => { f.GetValue(ang, null); dt.Columns.Add(f.Name, f.PropertyType); });

            var angajati = functie.GetAllAngajat();
            foreach (var angajat in angajati)
            {
                dt.Rows.Add(angajat.Id, angajat.Nume, angajat.Prenume, angajat.Data_nasteri, angajat.Data_Angajari, angajat.Salariu);
            }
            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite(@"D:\AngajatiDB.xml"));
            MessageBox.Show("Export reusit \n Filsierul se afla in D\n si are numele AngajatiDB.xml");           
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (Alegere_tip.Text == "JSON")
            {
            ExportJSON();
            }
            else
            {
            ExportXML();
            }
            this.Close();
        }
    }
}
