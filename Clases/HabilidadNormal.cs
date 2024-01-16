using Pruebas_35.Interfaces.Clases;
using Pruebas_35.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Clases
{

    public class HabilidadNormal : Habilidad, IHabilidadLanzable
    {
        public int CostoMana { get; private set; }
        public bool AutoAplicable { get; private set; }
        public TipoHabilidadLanzable Tipo { get; private set; }
        public int Potencia { get; private set; }

        public HabilidadNormal(string nombre, int nivelRequerido, ClasePersonaje clasePersonajeAsociada, int costoMana, bool autoAplicable, TipoHabilidadLanzable tipo, int potencia)
            : base("Activa" + Guid.NewGuid().ToString(), nombre, nivelRequerido, TipoHabilidad.Activa, clasePersonajeAsociada)
        {
            CostoMana = costoMana;
            AutoAplicable = autoAplicable;
            Tipo = tipo;
            Potencia = potencia;
        }

        public void Lanzar(IPersonaje lanzador, IPersonaje objetivo)
        {
            if (lanzador.Mana < CostoMana)
            {
                throw new Exception("No tienes suficiente mana para lanzar esta habilidad.");
            }

            lanzador.UsarMana(CostoMana);

            if (Tipo == TipoHabilidadLanzable.Dano)
            {
                objetivo.RecibirDano(Potencia);
            }
            else if (Tipo == TipoHabilidadLanzable.Curacion)
            {
                objetivo.RecibirCuracion(Potencia);
            }
        }
    }


}
