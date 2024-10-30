﻿using BL;
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
            int casillasPorFila = 10;  // Número de casillas por fila
            int tamanioCasilla = 50;   // Tamaño de cada casilla

            Panel tableroPanel = new Panel
            {
                Size = new Size(casillasPorFila * tamanioCasilla, casillasPorFila * tamanioCasilla),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(tableroPanel);

            // Crear el tablero en forma de zigzag
            bool zigzag = false;
            for (int i = 0; i < 100; i++)
            {
                int row = i / casillasPorFila;
                int column = zigzag ? casillasPorFila - (i % casillasPorFila) - 1 : i % casillasPorFila;

                Label casilla = new Label
                {
                    Size = new Size(tamanioCasilla, tamanioCasilla),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = (i + 1).ToString(),
                    Location = new Point(column * tamanioCasilla, row * tamanioCasilla),
                    BackColor = Color.White // Color normal de casillas
                };

                if ((i + 1) % 10 == 0) // Casillas trampa
                {
                    casilla.BackColor = Color.Orange;
                }

                casillas.Add(casilla);
                tableroPanel.Controls.Add(casilla);

                if ((i + 1) % casillasPorFila == 0)
                    zigzag = !zigzag;  // Alternar el zigzag
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

            // Narrar el evento
            NarrarMovimiento(jugador, numeroDado);

            // Cambiar el turno
            juego.CambiarTurno();
            lblTurno.Text = "Turno: " + juego.ObtenerJugadorActual().Nombre;
        }

        private void ActualizarPosicionJugador(Jugador jugador)
        {
            // Limpiar posiciones anteriores
            foreach (Label casilla in casillas)
            {
                casilla.BackColor = casilla.BackColor == Color.Orange ? Color.Orange : Color.White;
            }

            // Colocar al jugador en su nueva posición
            if (jugador.PosicionActual < casillas.Count)
            {
                casillas[jugador.PosicionActual].BackColor = jugador.ColorFicha;
            }
        }

        private void NarrarMovimiento(Jugador jugador, int numeroDado)
        {
            // Mostrar información sobre el movimiento
            lblNarrador.Text = $"{jugador.Nombre} tiró un {numeroDado} y avanzó a la casilla {jugador.PosicionActual + 1}.";

            if (juego.CasillasConTrampa.Contains(jugador.PosicionActual))
            {
                lblNarrador.Text += " ¡Cayó en una casilla trampa y regresa al inicio!";
            }
        }
    }
}
