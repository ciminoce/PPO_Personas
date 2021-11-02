using System;
using System.Linq;

namespace POO_Personas.Entidades
{
    public class Persona:ICloneable
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public Localidad Localidad { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is Persona))
            {
                return false;
            }

            return this.DNI == ((Persona) obj).DNI;
        }

        public override int GetHashCode()
        {
            return DNI.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {PrimerNombre} {SegundoNombre}";
        }

        public int GetEdad()
        {
            var edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.AddYears(edad)>DateTime.Today)
            {
                edad--;
            }

            return edad;
        }
    }
}
