using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolEntities;

namespace SchoolDAL
{
    public class CPersonDAL
    {
        public List<CPerson> Listar()
        {
            using (SchoolEntities contexto = new SchoolEntities())
            {
                var query = contexto.Person.Select(p => new CPerson
                {
                    PersonID = p.PersonID,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                    //HireDate = Convert.ToDateTime(p.HireDate),
                    //EnrollmentDate = Convert.ToDateTime(p.EnrollmentDate)
                });
                return query.ToList();
            }
        }

        public CPerson MostrarPersona(int ID)
        {
            using (SchoolEntities contexto = new SchoolEntities())
            {
                var query = contexto.Person.Select(p => new CPerson
                {
                    PersonID = p.PersonID,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                }).Where(x => x.PersonID == ID).FirstOrDefault();
                return query;
            }
        }

        public int InsertarPersona(CPerson per)
        {
            using (SchoolEntities contexto = new SchoolEntities())
            {
                try
                {
                    Person person = new Person();
                    person.PersonID = per.PersonID;
                    person.FirstName = per.FirstName;
                    person.LastName = per.LastName;
                    person.HireDate = per.HireDate;
                    person.EnrollmentDate = per.EnrollmentDate;
                    contexto.Person.Add(person);
                    int resultado = contexto.SaveChanges();
                    return resultado; //Devuelve el numero de cambios en la base de datos
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }
        }

        public int ModificarPersona(CPerson per)
        {
            System.Diagnostics.Debug.WriteLine("Entre " + per.LastName + " ");
            
            using (SchoolEntities contexto = new SchoolEntities())
            {
                Person persona = (from p in contexto.Person
                                  where p.PersonID == per.PersonID
                                  select p).FirstOrDefault();
                persona.FirstName = per.FirstName;
                persona.LastName = per.LastName;
                persona.HireDate = per.HireDate;
                persona.EnrollmentDate = per.EnrollmentDate;
                int resultado = contexto.SaveChanges();
                return resultado;
            }
        }

    }
}
