using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public int PosicionActual { get; set; }
        public bool PerdioTurno { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            PosicionActual = 0;
            PerdioTurno = false;
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
