using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class JuegoLudo
    {
        private Random random = new Random();
        public List<Jugador> Jugadores { get; set; }
        public int TurnoActual { get; set; }
        public int CasillasTotales { get; set; }
        public List<int> CasillasConTrampa { get; set; }

        public JuegoLudo(int numJugadores, int casillasTotales)
        {
            Jugadores = new List<Jugador>
        {
            new Jugador("Jugador 1", Color.Blue),
            new Jugador("Jugador 2", Color.Red)
        };

            TurnoActual = 0;
            CasillasTotales = casillasTotales;
            CasillasConTrampa = new List<int> { 10, 20, 30 }; // Ejemplo de casillas con trampa
        }

        public int TirarDado()
        {
            return random.Next(1, 7);
        }

        public Jugador ObtenerJugadorActual()
        {
            return Jugadores[TurnoActual];
        }

        public void CambiarTurno()
        {
            TurnoActual = (TurnoActual + 1) % Jugadores.Count;
        }

        public void VerificarTrampa(Jugador jugador)
        {
            if (CasillasConTrampa.Contains(jugador.PosicionActual))
            {
                jugador.Reiniciar();
            }
        }
    }
}
