using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoCaiV01.Entidades;

namespace ProyectoCaiV01.Archivos
{
    internal static class VuelosArchivo
    {
        
        static List<Vuelo> todos;

        static VuelosArchivo()
        {
            //si existe el archivo...
            if (File.Exists("Vuelo.json"))
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Vuelo.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Vuelo>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Vuelo>();
            }
        }


        //Estilo 1: este modulo devuelve una lista de todas las personas
        //y el resto del sistema trabaja con eso.
        public static List<Vuelo> ObtenerTodas()
        {
            return todos.ToList();
        }

    }
}
