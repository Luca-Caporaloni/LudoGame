using System;
using System.Drawing;

namespace BL
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int PosicionActual { get; set; }
        public bool PerdioTurno { get; set; }
        public Color ColorFicha { get; set; }

        public Jugador(string nombre, Color colorFicha)
        {
            Nombre = nombre;
            PosicionActual = 0;
            PerdioTurno = false;
            ColorFicha = colorFicha;
        }

        public void Mover(int cantidad)
        {
            PosicionActual += cantidad;
        }

        public void Reiniciar()
        {
            PosicionActual = 0;
        }
    }
}
