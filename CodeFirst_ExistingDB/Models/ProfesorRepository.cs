using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_ExistingDB.Models
{
    public class ProfesorRepository
    {
        private ProfesorDBContext db = new ProfesorDBContext();

        public void UpdateEmployee(TBL_Profesor entProfesor)
        {
            //TBL_Profesor spUpdate = db.Profesor.SingleOrDefault(x => x.IdProfesor == entProfesor.IdProfesor);
            //spUpdate.Nombre = entProfesor.Nombre;
            //spUpdate.ApellidoPaterno = entProfesor.ApellidoPaterno;
            //spUpdate.ApellidoMaterno = entProfesor.ApellidoMaterno;
            //spUpdate.DiaNacimiento = entProfesor.DiaNacimiento;
            //spUpdate.MesNacimiento = entProfesor.MesNacimiento;
            //spUpdate.AnoNacimiento = entProfesor.AnoNacimiento;
            //spUpdate.LugardeNacimiento = entProfesor.LugardeNacimiento;
            //spUpdate.Domicilio = entProfesor.Domicilio;
            //spUpdate.CorreoElectronico = entProfesor.CorreoElectronico;
            //spUpdate.Telefono = entProfesor.Telefono;
            //db.SaveChanges();
        }
    }
}