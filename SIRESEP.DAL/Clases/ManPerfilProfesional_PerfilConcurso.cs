using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
   public class ManPerfilProfesional_PerfilConcurso: IManPerfilProfesional_PerfilConcurso
    {
        private static ManPerfilProfesional_PerfilConcurso Instancia;

        public static ManPerfilProfesional_PerfilConcurso _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilProfesional_PerfilConcurso();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }
        public void Actualizar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(perfilProfesional_PerfilConcurso).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        public void Eliminar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.perfilProfesional_PerfilConcurso.Find(perfilProfesional_PerfilConcurso.idMatch);
                entities.perfilProfesional_PerfilConcurso.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.perfilProfesional_PerfilConcurso.Add(perfilProfesional_PerfilConcurso);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<perfilProfesional_PerfilConcurso> Mostrar()
        {
            //Inicializamos
            List<perfilProfesional_PerfilConcurso> lista = new List<perfilProfesional_PerfilConcurso>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.perfilProfesional_PerfilConcurso.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
