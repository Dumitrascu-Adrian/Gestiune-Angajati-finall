using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace versiune1
{
    class FunctiDB
    {
        public void Insert(Angajat angajat)
        {
            using (var Context = new EmployeeEntities())
            {
                Context.Angajats.Add(angajat);
                Context.SaveChanges();
            }
        }
            public void Update(int id, Angajat ang)
        {
            using (var context = new EmployeeEntities())
            {
                var angajat = context.Angajats.Where(s => s.Id == id).FirstOrDefault<Angajat>();
                angajat.Nume = ang.Nume;
                angajat.Prenume = ang.Prenume;
                angajat.Data_Angajari = ang.Data_Angajari;
                angajat.Data_nasteri = ang.Data_nasteri;
                angajat.Salariu = ang.Salariu;
                context.SaveChanges();
            }
        }
        public Angajat GetAngajat(int id)
        {
            using (var context = new EmployeeEntities())
            {
                var angajat = context.Angajats.Where(s => s.Id == id).FirstOrDefault<Angajat>();
                return angajat;
            }
        }
        public List<Angajat> GetAllAngajat()
        {
            using (var context = new EmployeeEntities())
            {
                var angajati = context.Angajats.ToList();
                return angajati;
            }
        }
        public void StergeAngajat(int id)
        {
            using (var context = new EmployeeEntities())
            {
                var delete = context.Angajats.Where(s => s.Id == id).First<Angajat>();
                context.Angajats.Remove(delete);
                context.SaveChanges();
            }
        }
    }
}
