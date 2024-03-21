using Examen1.DAL;
using Examen1.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.BSS
{
    public class PersonaBSS
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public Persona ObtenerPersonaIdBss(int id)
        {
            return dal.ObtenerPersonaIdDal(id);
        }

    }
}
