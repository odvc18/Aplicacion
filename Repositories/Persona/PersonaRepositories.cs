using Model.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repositories.Persona
{
    public class PersonaRepositories
    {
        public List<Personas> GetAllPersonas()
        {
            List<Personas> result = null;
            try
            {
                using (RegistrosEntities context = new RegistrosEntities())
                {
                    var query = context.Personas.ToList();
                    if (query != null && query.Count > 0)
                        result = query;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void CreatePersona(Personas persona)
        {
            try
            {
                using (RegistrosEntities context = new RegistrosEntities())
                {
                    context.Entry<Personas>(persona).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidateIdentificacion(string tipoIdentificacion, string numeroIdentificacion)
        {
            bool result = false;
            try
            {
                using (RegistrosEntities context = new RegistrosEntities())
                {
                    var query = context.Personas.Where(x => x.TipoIdentificacion == tipoIdentificacion && x.NumeroIdentificacion == numeroIdentificacion).ToList();
                    result = query != null && query.Count > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
