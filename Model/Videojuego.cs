using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Model
{
    public class Videojuego
    {
       /* public string t_nombre { get; set; }
        public bool t_gano { get; set; }
        public int t_puntos { get; set; }*/

        public string t_nombre { get; set; }
        public int t_juegosGanados { get; set; }
        public int t_juegosPerdidos { get; set; }
        public int t_puntos { get; set; }


        public Videojuego(string nombre)
        {
            t_nombre = nombre;
            t_juegosGanados = 0;
            t_juegosPerdidos = 0;
            t_puntos = 0;
        }

        public void RegistrarJuego(bool gano)
        {
            if (gano)
            {
                t_juegosGanados++;
                t_puntos += 100;
            }
            else
            {
                t_juegosPerdidos++;
                t_puntos -= 20;
            }
        }

        // Método para representar el videojuego como una cadena.
        public override string ToString()
        {
            return $"{t_nombre},{t_juegosGanados},{t_juegosPerdidos},{t_puntos}";
        }


    }
}
