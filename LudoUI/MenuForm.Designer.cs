namespace LudoUI
{
    partial class MenuForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.rbPrivado = new System.Windows.Forms.RadioButton();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUDO GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(341, 94);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 1;
            // 
            // rbPrivado
            // 
            this.rbPrivado.AutoSize = true;
            this.rbPrivado.Location = new System.Drawing.Point(341, 136);
            this.rbPrivado.Name = "rbPrivado";
            this.rbPrivado.Size = new System.Drawing.Size(93, 17);
            this.rbPrivado.TabIndex = 2;
            this.rbPrivado.TabStop = true;
            this.rbPrivado.Text = "Lobby Privada";
            this.rbPrivado.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(264, 177);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear Lobby";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnUnirse
            // 
            this.btnUnirse.Location = new System.Drawing.Point(355, 177);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(75, 23);
            this.btnUnirse.TabIndex = 4;
            this.btnUnirse.Text = "Unirse";
            this.btnUnirse.UseVisualStyleBackColor = true;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Location = new System.Drawing.Point(445, 177);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarJuego.TabIndex = 5;
            this.btnIniciarJuego.Text = "Iniciar Juego";
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.rbPrivado);
            this.Controls.Add(this.txtNombreJugador);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.RadioButton rbPrivado;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.Label label2;
    }
}

