using Model.Types;
using Repositories.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persona
{
    public class PersonaDomain
    {
        private PersonaRepositories repo = new PersonaRepositories();

        public List<Personas> GetAllPersonas()
        {
            try
            {
                return repo.GetAllPersonas();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string ValidateCreatePersona(Personas persona)
        {
            string result = "";
            try
            {
                if(repo.ValidateIdentificacion(persona.TipoIdentificacion, persona.NumeroIdentificacion))
                {
                    result += "No se puede crear la persona debido a que ya existe con ese tipo y número de identificación. \n";
                }
                if(string.IsNullOrEmpty(persona.Direccion) && string.IsNullOrEmpty(persona.Direccion2) && string.IsNullOrEmpty(persona.Correo) 
                    && string.IsNullOrEmpty(persona.Correo2))
                {
                    result += "Para la creación de la persona debe diligenciar una dirección o un correo electronico.";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void CreatePersona(Personas persona)
        {
            try
            {
                repo.CreatePersona(persona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
