using ExamenFinal.Model;
using ExamenFinal.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal
{
    public partial class Form2 : Form
    {
        private ManejadorVideojuegos manejador;
        private List<string> nombresVideojuegos;
        public Form2()
        {
            InitializeComponent();
            manejador = new ManejadorVideojuegos();
            nombresVideojuegos = new List<string> { "Juego1", "Juego2", "Juego3", "Otro" };
            CargarComboBox();

            ActualizarTabla();
            ActualizarPuntosTotales();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // Método para cargar el ComboBox con los nombres de los videojuegos.
        private void CargarComboBox()
        {
            cbVideojuegos.Items.Clear();
            cbVideojuegos.Items.AddRange(nombresVideojuegos.ToArray());
        }

        // Evento que se dispara al seleccionar un videojuego del ComboBox.
        private void cbVideojuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVideojuegos.SelectedItem.ToString() == "Otro")
            {
                txtNuevoVideojuego.Enabled = true;
            }
            else
            {
                txtNuevoVideojuego.Enabled = false;
                txtNuevoVideojuego.Text = string.Empty;
            }
        }

        // Evento que se dispara al hacer clic en el botón de agregar videojuego.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreJuego = cbVideojuegos.SelectedItem.ToString() == "Otro" ? txtNuevoVideojuego.Text : cbVideojuegos.SelectedItem.ToString();
            if (string.IsNullOrEmpty(nombreJuego))
            {
                MessageBox.Show("Ingrese el nombre del videojuego.");
                return;
            }

            bool gano = rbGano.Checked;
           // Videojuego juego = new Videojuego(nombreJuego, gano);
            manejador.RegistrarJuego(nombreJuego, gano);
            //manejador.AgregarVideojuego(juego);

            if (cbVideojuegos.SelectedItem.ToString() == "Otro" && !nombresVideojuegos.Contains(nombreJuego))
            {
                nombresVideojuegos.Add(nombreJuego);
                CargarComboBox();
            }

            ActualizarTabla();
            ActualizarPuntosTotales();
        }

        // Método para actualizar la tabla con los videojuegos registrados.
        private void ActualizarTabla()
        {
            lvVideojuegos.Items.Clear();
            foreach (var juego in manejador.ObtenerVideojuegos())
            {
                var item = new ListViewItem(new[] { juego.t_nombre, juego.t_puntos.ToString() });
                item.Tag = juego;
                lvVideojuegos.Items.Add(item);
            }
        }

        // Método para actualizar el total de puntos acumulados.
        private void ActualizarPuntosTotales()
        {
            lblPuntosTotales.Text = $"Puntos Totales: {manejador.ObtenerPuntosTotales()}";
        }

       

        private void lvVideojuegos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvVideojuegos.SelectedItems.Count > 0)
            {
                var item = lvVideojuegos.SelectedItems[0];
                var juego = (Videojuego)item.Tag;
                lblDetalleJuego.Text = $"Ganados: {juego.t_juegosGanados}, Perdidos: {juego.t_juegosPerdidos}";
            }
        }

        private void lvVideojuegos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Si el elemento está seleccionado, usa un color de fondo diferente.
                e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else
            {
                // Si el elemento no está seleccionado, usa el color de fondo predeterminado.
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            }

            // Dibuja el texto del elemento.
            e.Graphics.DrawString(e.Item.Text, e.Item.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
        }
    }
}
