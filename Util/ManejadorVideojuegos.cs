using ExamenFinal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Util
{
    public class ManejadorVideojuegos
    {
        private List<Videojuego> videojuegos;
        private const string archivo = "base_de_informacion.txt";

        // Constructor que inicializa la lista de videojuegos y carga datos del archivo.
        public ManejadorVideojuegos()
        {
            videojuegos = new List<Videojuego>();
            CargarDatos();
        }


        /* public void AgregarVideojuego(Videojuego videojuego)
         {
             videojuegos.Add(videojuego);
             GuardarDatos();
         }*/


        // Método para agregar un videojuego a la lista.
        public void RegistrarJuego(string nombre, bool gano)
        {
            var videojuego = videojuegos.Find(v => v.t_nombre == nombre);
            if (videojuego == null)
            {
                videojuego = new Videojuego(nombre);
                videojuegos.Add(videojuego);
            }
            videojuego.RegistrarJuego(gano);
            GuardarDatos();
        }

        // Método para obtener la lista de videojuegos.
        public List<Videojuego> ObtenerVideojuegos()
        {
            return videojuegos;
        }

        // Método para calcular los puntos acumulados.
        public int ObtenerPuntosTotales()
        {
            int total = 0;
            foreach (var juego in videojuegos)
            {
                total += juego.t_puntos;
            }
            return total;
        }


        // Método para guardar los datos en un archivo.
        private void GuardarDatos()
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                foreach (var juego in videojuegos)
                {
                    writer.WriteLine(juego.ToString());
                }
            }
        }

        // Método para cargar los datos desde un archivo.
        private void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        var datos = linea.Split(',');
                        if (datos.Length == 4)
                        {
                            string nombre = datos[0];
                            int juegosGanados = int.Parse(datos[1]);
                            int juegosPerdidos = int.Parse(datos[2]);
                            int puntos = int.Parse(datos[3]);

                            Videojuego juego = new Videojuego(nombre)
                            {
                                t_juegosGanados = juegosGanados,
                                t_juegosPerdidos = juegosPerdidos,
                                t_puntos = puntos
                            };
                            videojuegos.Add(juego);
                        }
                    }
                }
            }
        }
    }
}
