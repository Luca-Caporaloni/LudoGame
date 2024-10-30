namespace LudoGame
{
    partial class LudoForm
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
            this.btnTirarDado = new System.Windows.Forms.Button();
            this.lblNumeroDado = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNarrador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTirarDado
            // 
            this.btnTirarDado.Location = new System.Drawing.Point(713, 202);
            this.btnTirarDado.Name = "btnTirarDado";
            this.btnTirarDado.Size = new System.Drawing.Size(75, 23);
            this.btnTirarDado.TabIndex = 0;
            this.btnTirarDado.Text = "Tirar Dado";
            this.btnTirarDado.UseVisualStyleBackColor = true;
            this.btnTirarDado.Click += new System.EventHandler(this.btnTirarDado_Click);
            // 
            // lblNumeroDado
            // 
            this.lblNumeroDado.AutoSize = true;
            this.lblNumeroDado.Location = new System.Drawing.Point(728, 228);
            this.lblNumeroDado.Name = "lblNumeroDado";
            this.lblNumeroDado.Size = new System.Drawing.Size(42, 13);
            this.lblNumeroDado.TabIndex = 1;
            this.lblNumeroDado.Text = "Dado: -";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(24, 19);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(88, 13);
            this.lblTurno.TabIndex = 2;
            this.lblTurno.Text = "Turno: Jugador 1";
            // 
            // lblNarrador
            // 
            this.lblNarrador.AutoSize = true;
            this.lblNarrador.Location = new System.Drawing.Point(710, 19);
            this.lblNarrador.Name = "lblNarrador";
            this.lblNarrador.Size = new System.Drawing.Size(48, 13);
            this.lblNarrador.TabIndex = 3;
            this.lblNarrador.Text = "Narrador";
            // 
            // LudoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNarrador);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblNumeroDado);
            this.Controls.Add(this.btnTirarDado);
            this.Name = "LudoForm";
            this.Text = "Ludo Game";
            this.Load += new System.EventHandler(this.LudoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTirarDado;
        private System.Windows.Forms.Label lblNumeroDado;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblNarrador;
    }
}
