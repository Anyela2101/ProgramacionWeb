using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulsacionesdonet.Models
{
    public class PersonaInputModels
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }

    public class PersonaViewModel : PersonaInputModels
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombres = persona.Nombres;
            Apellidos = persona.Apellidos;
            Edad = persona.Edad;
            Sexo = persona.Sexo;
            Pulsacion = persona.Pulsacion;
        }
        public decimal Pulsacion { get; set; }
    }
}