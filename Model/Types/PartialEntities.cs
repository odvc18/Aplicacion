using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Types
{
    [MetadataType(typeof(PersonasMT))]
    public partial class Personas
    {
        public class PersonasMT
        {
            [Required(ErrorMessage = "Debe seleccionar un tipo de identificación.")]
            public string TipoIdentificacion { get; set; }

            [Required(ErrorMessage = "Debe ingresar un número de identificación.")]
            public string NumeroIdentificacion { get; set; }

            [Required(ErrorMessage = "Debe ingresar un nombre.")]
            [RegularExpression("[a-zA-Z$@$!&,ÁÉÍÓÚÑ'\":()Üüáéíóúñ;%*+-–. ]+$", ErrorMessage = "El valor ingresado tiene caracteres invalidos.")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "Debe ingresar un apellido.")]
            [RegularExpression("[a-zA-Z$@$!&,ÁÉÍÓÚÑ'\":()Üüáéíóúñ;%*+-–. ]+$", ErrorMessage = "El valor ingresado tiene caracteres invalidos.")]
            public string Apellido { get; set; }

            [Required(ErrorMessage = "Debe ingresar una fecha de nacimiento.")]
            public DateTime FechaNacimiento { get; set; }

            [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", ErrorMessage = "El valor ingresado no tiene el formato correcto.")]
            public string Correo { get; set; }

            [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", ErrorMessage = "El valor ingresado no tiene el formato correcto.")]
            public string Correo2 { get; set; }

            [RegularExpression("^(\\d{10})$", ErrorMessage = "Se encuentra caracteres invalidos")]
            public string Telefono { get; set; }

            [RegularExpression("^(\\d{10})$", ErrorMessage = "Se encuentra caracteres invalidos")]
            public string Telefono2 { get; set; }

            [RegularExpression("[a-zA-Z0-9$@$!,ÁÉÍÓÚÑ'\":_()#Üüáéíóúñ;%/&*+-. ]+$", ErrorMessage = "El valor ingresado tiene caracteres invalidos ")]
            public string Direccion { get; set; }

            [RegularExpression("[a-zA-Z0-9$@$!,ÁÉÍÓÚÑ'\":_()#Üüáéíóúñ;%/&*+-. ]+$", ErrorMessage = "El valor ingresado tiene caracteres invalidos ")]
            public string Direccion2 { get; set; }
        }
    }
}
