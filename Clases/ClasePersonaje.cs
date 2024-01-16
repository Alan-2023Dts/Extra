using Pruebas_35.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_35.Clases
{
    public class Personaje : IPersonaje
    {
        public string Nombre { get; private set; }
        public int Nivel { get; private set; }
        public int Vida { get; private set; }
        public int Mana { get; private set; }

        public Personaje(string nombre, int nivel, int vida, int mana)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = vida;
            Mana = mana;
        }

        public void RecibirDano(int dano)
        {
            Vida -= dano;
            if (Vida < 0) Vida = 0;
        }

        public void RecibirCuracion(int curacion)
        {
            Vida += curacion;
        }

        public void UsarMana(int costoMana)
        {
            Mana -= costoMana;
            if (Mana < 0) Mana = 0;
        }
    }

}
