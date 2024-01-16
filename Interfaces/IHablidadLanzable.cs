using Pruebas_35.Interfaces.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Interfaces
{


    public enum TipoHabilidadLanzable
    {
        Dano,
        Curacion
    }
    public interface IHabilidadLanzable : IHabilidad
    {
        int CostoMana { get; }
        bool AutoAplicable { get; }
        TipoHabilidadLanzable Tipo { get; }
        int Potencia { get; }

        void Lanzar(IPersonaje lanzador, IPersonaje objetivo);
    }
}
