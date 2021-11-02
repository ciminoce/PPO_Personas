using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Personas.Entidades;

namespace POO_Personas.Datos
{
    public class ManejadorDeArchivo
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Personas.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Personas.bak";

        public void EditarRegistroEnArchivo(Persona personaModificada)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                var personaEnArchivo = ConstruirPersona(linea);
                if (personaEnArchivo.Equals(personaModificada))
                {
                    linea = ConstruirLinea(personaModificada);
                }
                escritor.WriteLine(linea);
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }



        public List<Persona> LeerDatosDelArchivo()
        {
            var lista = new List<Persona>();
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Persona persona = ConstruirPersona(linea);
                    lista.Add(persona);
                }
                lector.Close();
            }
            return lista;
        }

        private Persona ConstruirPersona(string linea)
        {
            var campos = linea.Split('|');
            return new Persona()
            {
                DNI = int.Parse(campos[0]),
                Apellido = campos[1],
                PrimerNombre = campos[2],
                SegundoNombre = campos[3],
                FechaNacimiento = DateTime.Parse(campos[4]),
                Sexo = (Sexo) int.Parse(campos[5]),
                Localidad = (Localidad) int.Parse(campos[6])
            };
        }

        public void BorrarRegistroEnArchivo(Persona persona)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Persona personaEnArchivo = ConstruirPersona(linea);
                if (!personaEnArchivo.Equals(persona))
                {
                    escritor.WriteLine(linea);
                }
            }
            escritor.Close();
            lector.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }


        public void GuardarEnArchivo(Persona persona)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(persona);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Persona persona)
        {
            return $"{persona.DNI}|{persona.Apellido}|" +
                   $"{persona.PrimerNombre}|{persona.SegundoNombre}|"+
                    $"{persona.FechaNacimiento.ToShortDateString()}|" +
                   $"{persona.Sexo.GetHashCode()}|{persona.Localidad.GetHashCode()}";
        }

    }
}
