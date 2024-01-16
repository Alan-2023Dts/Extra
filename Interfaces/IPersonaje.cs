using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Interfaces
{
  
        public interface IPersonaje
        {
            string Nombre { get; }
            int Nivel { get; }
            int Vida { get; }
            int Mana { get; }

            void RecibirDano(int dano);
            void RecibirCuracion(int curacion);
            void UsarMana(int costoMana);
        }

    

}
