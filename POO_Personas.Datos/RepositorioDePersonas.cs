using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using POO_Personas.Entidades;

namespace POO_Personas.Datos
{
    public class RepositorioDePersonas
    {
        private List<Persona> ListaPersonas;
        private ManejadorDeArchivo manejador;

        public static RepositorioDePersonas instancia = null;

        public static RepositorioDePersonas GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new RepositorioDePersonas();
            }

            return instancia;
        }
        private RepositorioDePersonas()
        {
            ListaPersonas = new List<Persona>();
            manejador = new ManejadorDeArchivo();
            ListaPersonas = manejador.LeerDatosDelArchivo();
        }

        public void Agregar(Persona p)
        {
            manejador.GuardarEnArchivo(p);
            ListaPersonas.Add(p);
        }
        public int GetCantidad()
        {
            return ListaPersonas.Count;
        }
        public void Borrar(Persona p)
        {
            manejador.BorrarRegistroEnArchivo(p);
            ListaPersonas.Remove(p);
        }

        public void Editar(Persona p)
        {
            manejador.EditarRegistroEnArchivo(p);
            int index = ListaPersonas.IndexOf(p);
            ListaPersonas.RemoveAt(index);
            ListaPersonas.Insert(index, p);

        }
        public bool ExistePersona(Persona p)
        {
            return ListaPersonas.Contains(p);
        }
        public List<Persona> GetLista()
        {
            return ListaPersonas;
        }

        public bool ExisteObjeto(Persona p)
        {
            return ListaPersonas.Contains(p);
        }


        public List<Persona> GetListaFiltradaPorSexo(Sexo sexo)
        {
            return ListaPersonas.Where(p => p.Sexo == sexo).ToList();
        }

        public List<Persona> GetListaFiltradaComienza(string comienza)
        {
            return ListaPersonas.Where(p => p.Apellido.StartsWith(comienza)).ToList();
        }

        public List<Persona> GetListaFiltradaPorLocalidad(Localidad localidad)
        {
            return ListaPersonas.Where(p => p.Localidad == localidad).ToList();
        }

        public List<Persona> GetListaFiltrada(Func<Persona, bool> predicado)
        {
            return ListaPersonas.Where(predicado).ToList();
        }

        //public List<Persona> GetListaOrdenadaAZ()
        //{
        //    //return ListaPersonas.OrderBy(p => p.Apellido).ThenBy(p => p.Nombre).ToList();
        //}
    }
}
