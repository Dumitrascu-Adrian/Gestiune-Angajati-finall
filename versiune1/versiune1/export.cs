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
        public export()
        {
            InitializeComponent();
        }

        public object Table { get; private set; }

        private void button_ok_Click(object sender, EventArgs e)
        {
              XmlDocument xmlDoc = new XmlDocument();
               if (Alegere_tip.Text == "JSON")
               {

                   using (var context = new EmployeeEntities())
                   {
                       var query = from st in context.Angajats

                                   select st;

                       var angajati = context.Angajats.ToList();

                       var jsonSerialiser = new System.Web.Script.Serialization.JavaScriptSerializer();
                       string jsonString = jsonSerialiser.Serialize(angajati);
                       System.IO.File.WriteAllText(@"D:\Angajatlist.json", jsonString);


                   }
                   MessageBox.Show("Export reusit \n Fisierul se afla in D");
                   this.Close();
               }
               else
               {
                   DataSet ds = new DataSet();
                Angajat ang = new Angajat();
                DataTable dt = new DataTable();
                ang.GetType().GetProperties().ToList().ForEach(f => { f.GetValue(ang, null); dt.Columns.Add(f.Name, f.PropertyType); });

                using (var context = new EmployeeEntities())
                {
                    var query = from st in context.Angajats

                                select st;

                    var angajati = context.Angajats.ToList();
                    foreach (var angajatt in angajati)
                    {
                        dt.Rows.Add(angajatt.Id, angajatt.Nume, angajatt.Prenume, angajatt.Data_nasteri, angajatt.Data_Angajari, angajatt.Salariu);
                    }
                    ds.Tables.Add(dt);
                    ds.WriteXml(File.OpenWrite(@"D:\test1.xml"));
                    MessageBox.Show("Export reusit \n Fisierul se afla in D");
                }
              
               


                   
                  
               }
            this.Close();

        }





    }
}
