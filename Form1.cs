//using MaterialSkin;
//using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenFinal
{
    public partial class Form1 : Form // MaterialSkin.Controls.MaterialForm
    {
        //private readonly MaterialSkinManager materialSkinManager;

        private string[] items = new string[10]
       {
            "Italia", "Camerun", "Perú", "Guatemala", "Honduras",
            "Portugal", "España", "Argentina", "Zuiza", "Colombia"
       };
        private int currentIndex = 10;

        public Form1()
        {
            InitializeComponent();

        

            // Configurar ListView Unsorted (Desordenado).
            ConfigurarListViewUnsorted();

            // Configurar ListView Sorted (Ordenado)
            ConfigurarListViewSorted();
     

            // Actualizar ListView Unsorted con los datos iniciales.
            ActualizaListView(lvUnsorted, items);

        }

        private void ConfigurarListViewUnsorted()
        {
            lvUnsorted.View = View.Details;
            lvUnsorted.FullRowSelect = true;
            lvUnsorted.Scrollable = true;
        }
        private void ConfigurarListViewSorted()
        {
            lvSorted.View = View.Details;
            lvSorted.FullRowSelect = true;
            lvSorted.Scrollable = true;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón Agregar, añade un nuevo ítem al array.
        private void btmAgregar_Click(object sender, EventArgs e)
        {
            
        }

        //mensage generico
        private void Mensage(string mensage)
        {
            //MessageBox msn = new MessageBox("");
           // MaterialSnackBar SnackBarMessage = new MaterialSnackBar(mensage, "OK", true);
           // SnackBarMessage.Show(this);
        }

        // Evento del botón Ordenar, ordena el array usando QuickSort y actualiza el ListView Sorted.
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
           
        }

        // Método para agregar un nuevo ítem al array.
        private void AgregarItem(string newItem)
        {
            if (currentIndex >= items.Length)
            {
                Array.Resize(ref items, items.Length + 1);// Redimensiona el array si es necesario.
            }
            items[currentIndex] = newItem; // Añade el nuevo ítem al array.
            currentIndex++; // Incrementa el índice actual.
            lvUnsorted.Items.Add(new ListViewItem(newItem));

        }

        // Método para actualizar un ListView con el contenido de un array.
        private void ActualizaListView(System.Windows.Forms.ListView listView, string[] array)
        {
            
            foreach (var item in array)
            {
                listView.Items.Add(new ListViewItem(item));
            }
            
        }

        // Método recursivo para ordenar el array usando QuickSort.
        private void QuickSort(string[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Particion(array, left, right);// Particiona el array y obtiene el índice del pivote.
                QuickSort(array, left, pivotIndex - 1);// Ordena recursivamente la sublista izquierda.
                QuickSort(array, pivotIndex + 1, right);// Ordena recursivamente la sublista derecha.
            }
        }

        // Método para particionar el array para QuickSort.
        private int Particion(string[] array, int left, int right)
        {
            string pivot = array[right]; // Selecciona el elemento pivote.
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (string.Compare(array[i], pivot, StringComparison.Ordinal) < 0)
                {
                    low++;
                    Intercambiar(array, low, i); // Intercambia elementos si es necesario.
                }
            }
            Intercambiar(array, low + 1, right);  // Intercambia el pivote al lugar correcto.
            return low + 1; // Devuelve el índice del pivote.
        }

        // Método para intercambiar dos elementos en un array.
        private void Intercambiar(string[] array, int i, int j)
        {
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txtNuevoTexto.Text))
            {
                string ss = txtNuevoTexto.Text;
                string text = ss.Substring(0,1).ToUpper() + ss.Substring(1).ToLower();

                AgregarItem(text);// Llama al método para agregar el nuevo ítem.
                txtNuevoTexto.Clear(); // Limpia el TextBox.
                this.Mensage("Dato agregado correctamente");
            }
            else
            { //muestra una alerta
                this.Mensage("Debe ingresar un texto");
            }
        }

        private void btnOrdena_Click_1(object sender, EventArgs e)
        {
            if (lvSorted.Items.Count > 0)
            {
                lvSorted.Items.Clear();
            }
            //lvSorted.Items.Clear();
            string[] sortedItems = (string[])items.Clone();// Copia el array para mantener el original sin cambios
            QuickSort(sortedItems, 0, currentIndex - 1); // Ordena el array copiado.



            ActualizaListView(lvSorted, sortedItems); // Actualiza el ListView Sorted con el array ordenado.
        }
    }
}
