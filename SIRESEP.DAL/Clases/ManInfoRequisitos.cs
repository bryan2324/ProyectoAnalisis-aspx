using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SIRESEP.DAL.Clases
{
    public class ManInfoRequisitos : IManInfoRequisitos
    {
        private static ManInfoRequisitos Instancia;

        public static ManInfoRequisitos _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoRequisitos();
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
        public void Actualizar(InfoRequisitos requisito)
    {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(requisito).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

    public void Eliminar(InfoRequisitos requisito)
    {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoRequisitos.Find(requisito.idInfoRequisitos);
                entities.InfoRequisitos.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

    public void Insertar(InfoRequisitos requisito)
    {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoRequisitos.Add(requisito);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
     }

    public List<InfoRequisitos> Mostrar()
    {
            //Inicializamos
            List<InfoRequisitos> lista = new List<InfoRequisitos>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoRequisitos.ToList();
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
