using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class NodoABB
    {
        public Artista Datos { get; set; }
        public NodoABB Izquierdo { get; set; }
        public NodoABB Derecho { get; set; }

        public NodoABB(Artista datos)
        {
            Datos = datos;
        }
    }
}
