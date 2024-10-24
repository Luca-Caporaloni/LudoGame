using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JuegoRepository
    {
        // Simulación de guardado de partida (más adelante se conectará a una base de datos)
        public void GuardarPartida(List<string> jugadores)
        {
            // Lógica para guardar los datos de los jugadores en una base de datos
        }

        public List<string> CargarPartida()
        {
            // Lógica para cargar datos de los jugadores de una base de datos
            return new List<string> { "Jugador 1", "Jugador 2" };
        }
    }
}
