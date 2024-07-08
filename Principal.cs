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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void enunciado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form2
            Form1 form1 = new Form1();
            // Mostrar Form1 enunciado 1
            form1.Show();
        }

        private void enunciado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // Mostrar Form2 enunciado 2
            form2.Show();
        }
    }
}
