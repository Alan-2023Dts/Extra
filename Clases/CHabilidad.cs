using Pruebas_35.Interfaces.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Clases
{
    public class Habilidad : IHabilidad
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public int NivelRequerido { get; private set; }
        public TipoHabilidad Clase { get; private set; }
        public ClasePersonaje ClasePersonajeAsociada { get; private set; }

        public Habilidad(string id, string nombre, int nivelRequerido, TipoHabilidad clase, ClasePersonaje clasePersonajeAsociada)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío o en blanco.", nameof(nombre));
            }

            if (nivelRequerido < 1)
            {
                throw new ArgumentException("El nivel requerido debe ser mayor o igual a 1.", nameof(nivelRequerido));
            }


            Id = Guid.NewGuid();
            Nombre = nombre;
            NivelRequerido = nivelRequerido;
            Clase = clase;
            ClasePersonajeAsociada = clasePersonajeAsociada;


           

        }
    }
}


