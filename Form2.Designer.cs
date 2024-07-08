namespace ExamenFinal
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbVideojuegos;
        private System.Windows.Forms.TextBox txtNuevoVideojuego;
        private System.Windows.Forms.RadioButton rbGano;
        private System.Windows.Forms.RadioButton rbPerdio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvVideojuegos;
        private System.Windows.Forms.Label lblPuntosTotales;
        private System.Windows.Forms.Label lblDetalleJuego;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cbVideojuegos = new System.Windows.Forms.ComboBox();
            this.txtNuevoVideojuego = new System.Windows.Forms.TextBox();
            this.rbGano = new System.Windows.Forms.RadioButton();
            this.rbPerdio = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvVideojuegos = new System.Windows.Forms.ListView();
            this.lblPuntosTotales = new System.Windows.Forms.Label();
            this.lblDetalleJuego = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVideojuegos
            // 
            this.cbVideojuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideojuegos.FormattingEnabled = true;
            this.cbVideojuegos.Location = new System.Drawing.Point(12, 12);
            this.cbVideojuegos.Name = "cbVideojuegos";
            this.cbVideojuegos.Size = new System.Drawing.Size(200, 21);
            this.cbVideojuegos.TabIndex = 0;
            this.cbVideojuegos.SelectedIndexChanged += new System.EventHandler(this.cbVideojuegos_SelectedIndexChanged);

            // 
            // txtNuevoVideojuego
            // 
            this.txtNuevoVideojuego.Enabled = false;
            this.txtNuevoVideojuego.Location = new System.Drawing.Point(12, 39);
            this.txtNuevoVideojuego.Name = "txtNuevoVideojuego";
            this.txtNuevoVideojuego.Size = new System.Drawing.Size(200, 20);
            this.txtNuevoVideojuego.TabIndex = 1;
            // 
            // rbGano
            // 
            this.rbGano.AutoSize = true;
            this.rbGano.Location = new System.Drawing.Point(12, 65);
            this.rbGano.Name = "rbGano";
            this.rbGano.Size = new System.Drawing.Size(50, 17);
            this.rbGano.TabIndex = 2;
            this.rbGano.TabStop = true;
            this.rbGano.Text = "Ganó";
            this.rbGano.UseVisualStyleBackColor = true;
            // 
            // rbPerdio
            // 
            this.rbPerdio.AutoSize = true;
            this.rbPerdio.Location = new System.Drawing.Point(12, 88);
            this.rbPerdio.Name = "rbPerdio";
            this.rbPerdio.Size = new System.Drawing.Size(56, 17);
            this.rbPerdio.TabIndex = 3;
            this.rbPerdio.TabStop = true;
            this.rbPerdio.Text = "Perdió";
            this.rbPerdio.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvVideojuegos
            // 
            this.lvVideojuegos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                new System.Windows.Forms.ColumnHeader("Nombre") { Text = "Juego", Width = 200 },
                new System.Windows.Forms.ColumnHeader("Puntos") { Text = "Puntos", Width = 100 }});
            this.lvVideojuegos.Location = new System.Drawing.Point(12, 140);
            this.lvVideojuegos.Name = "lvVideojuegos";
            this.lvVideojuegos.Size = new System.Drawing.Size(400, 200);
            this.lvVideojuegos.TabIndex = 5;
            this.lvVideojuegos.View = System.Windows.Forms.View.Details;
            this.lvVideojuegos.SelectedIndexChanged += new System.EventHandler(this.lvVideojuegos_SelectedIndexChanged_1);

            // 
            // lblPuntosTotales
            // 
            this.lblPuntosTotales.AutoSize = true;
            this.lblPuntosTotales.Location = new System.Drawing.Point(280, 114);
            this.lblPuntosTotales.Name = "lblPuntosTotales";
            this.lblPuntosTotales.Size = new System.Drawing.Size(88, 13);
            this.lblPuntosTotales.TabIndex = 6;
            this.lblPuntosTotales.Text = "Puntos Totales: 0";
            // 
            // lblDetalleJuego
            // 
            this.lblDetalleJuego.AutoSize = true;
            this.lblDetalleJuego.Location = new System.Drawing.Point(12, 350);
            this.lblDetalleJuego.Name = "lblDetalleJuego";
            this.lblDetalleJuego.Size = new System.Drawing.Size(80, 13);
            this.lblDetalleJuego.TabIndex = 7;
            this.lblDetalleJuego.Text = "Detalles del juego seleccionado";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.lblDetalleJuego);
            this.Controls.Add(this.lblPuntosTotales);
            this.Controls.Add(this.lvVideojuegos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbPerdio);
            this.Controls.Add(this.rbGano);
            this.Controls.Add(this.txtNuevoVideojuego);
            this.Controls.Add(this.cbVideojuegos);
            this.Name = "Form1";
            this.Text = "Registro de Videojuegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       /* private void InitializeComponent()
        {
            

        }*/

        #endregion
    }
}