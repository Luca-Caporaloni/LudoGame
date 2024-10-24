using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LudoGame
{
    public partial class LudoForm : Form
    {
        private JuegoLudo juego;
        private List<Label> casillas;

        public LudoForm()
        {
            InitializeComponent();
            juego = new JuegoLudo(2, 100); // 2 jugadores y 100 casillas
            InicializarTablero();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarTablero()
        {
            casillas = new List<Label>();
            int casillasPorFila = 10;  // Por ejemplo, una fila de 10 casillas
            int tamanioCasilla = 50;   // Tamaño de cada casilla en píxeles

            // Crear un panel para contener las casillas
            Panel tableroPanel = new Panel
            {
                Size = new Size(casillasPorFila * tamanioCasilla, casillasPorFila * tamanioCasilla),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(tableroPanel);

            // Generar casillas dentro del panel
            for (int i = 0; i < 100; i++)
            {
                Label casilla = new Label
                {
                    Size = new Size(tamanioCasilla, tamanioCasilla),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = (i + 1).ToString(),
                    Location = new Point((i % casillasPorFila) * tamanioCasilla, (i / casillasPorFila) * tamanioCasilla)
                };

                casillas.Add(casilla);
                tableroPanel.Controls.Add(casilla);
            }
        }



        private void btnTirarDado_Click(object sender, EventArgs e)
        {
            // Tirar el dado y mostrar el número
            int numeroDado = juego.TirarDado();
            lblNumeroDado.Text = "Dado: " + numeroDado;

            // Mover al jugador actual
            Jugador jugador = juego.ObtenerJugadorActual();
            jugador.Mover(numeroDado);
            juego.VerificarTrampa(jugador);

            // Actualizar la posición del jugador visualmente
            ActualizarPosicionJugador(jugador);

            // Cambiar el turno
            juego.CambiarTurno();
            lblTurno.Text = "Turno: " + juego.ObtenerJugadorActual().Nombre;
        }

        private void ActualizarPosicionJugador(Jugador jugador)
        {
            // Limpiar las posiciones anteriores
            foreach (Label casilla in casillas)
            {
                casilla.BackColor = Color.White;
            }

            // Colocar al jugador en la nueva posición
            if (jugador.PosicionActual < casillas.Count)
            {
                casillas[jugador.PosicionActual].BackColor = Color.Red; // Cambiar el color para representar la ficha del jugador
            }
        }
    }
}
