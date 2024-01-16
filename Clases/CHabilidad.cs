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

       
    }

}
