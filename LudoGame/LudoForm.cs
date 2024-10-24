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
        public LudoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tamaño del tablero (puedes ajustarlo según el número de casillas)
            int filas = 10;
            int columnas = 10;

            // Configurar el DataGridView
            gridTablero.ColumnCount = columnas;
            gridTablero.RowCount = filas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    gridTablero.Rows[i].Cells[j].Value = (i * columnas) + j + 1; // Número de casilla
                }
            }

            // Deshabilitar edición y ajustar estilo
            gridTablero.ReadOnly = true;
            gridTablero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //MOVER JUGADOR
        private Random random = new Random();
        private int turnoActual = 1;
        private int posicionJugador1 = 0;
        private int posicionJugador2 = 0;

        private void MoverJugador(int numeroDado)
        {
            if (turnoActual == 1)
            {
                posicionJugador1 += numeroDado;
                if (posicionJugador1 >= gridTablero.ColumnCount * gridTablero.RowCount)
                    posicionJugador1 = gridTablero.ColumnCount * gridTablero.RowCount; // Llega al final

                // Limpiar casillas anteriores y mover al jugador
                LimpiarTablero();
                gridTablero.Rows[posicionJugador1 / gridTablero.ColumnCount].Cells[posicionJugador1 % gridTablero.ColumnCount].Style.BackColor = Color.Blue;
            }
            else
            {
                posicionJugador2 += numeroDado;
                if (posicionJugador2 >= gridTablero.ColumnCount * gridTablero.RowCount)
                    posicionJugador2 = gridTablero.ColumnCount * gridTablero.RowCount; // Llega al final

                // Limpiar casillas anteriores y mover al jugador
                LimpiarTablero();
                gridTablero.Rows[posicionJugador2 / gridTablero.ColumnCount].Cells[posicionJugador2 % gridTablero.ColumnCount].Style.BackColor = Color.Red;
            }
        }

        //LIMPIAR TABLERO
        private void LimpiarTablero()
        {
            foreach (DataGridViewRow fila in gridTablero.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    celda.Style.BackColor = Color.White; // Limpiar color
                }
            }
        }


        //TIRAR DADO

        private void btnTirarDado_Click(object sender, EventArgs e)
        {
            // Generar número aleatorio entre 1 y 6
            int numeroDado = random.Next(1, 7);
            lblNumeroDado.Text = "Dado: " + numeroDado;

            // Avanzar el turno
            lblTurno.Text = "Turno: Jugador " + turnoActual;

            // Lógica para avanzar el jugador
            MoverJugador(numeroDado);

            // Cambiar el turno (puedes tener más jugadores si lo deseas)
            turnoActual = turnoActual == 1 ? 2 : 1;
        }
    }


}
