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

        public LudoForm()
        {
            InitializeComponent();
            juego = new JuegoLudo(2, 100); // 2 jugadores y 100 casillas
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
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

            // Cambiar el turno
            juego.CambiarTurno();
            lblTurno.Text = "Turno: " + juego.ObtenerJugadorActual().Nombre;
        }
    }
}
