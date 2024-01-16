using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Interfaces.Clases
{

    public enum TipoHabilidad
    {
        Activa,
        Pasiva
    }

   
    public interface IHabilidad
    {
        string Id { get; }
        string Nombre { get; }
        int NivelRequerido { get; }

        TipoHabilidad Clase { get; }

    }

}
