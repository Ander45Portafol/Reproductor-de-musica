using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class ArbolBinario
    {
        public NodoABB Raiz { get; set; }

        public void Insertar(Artista artista)
        {
            Raiz = InsertarRec(Raiz, artista);
        }

        private NodoABB InsertarRec(NodoABB nodo, Artista artista)
        {
            if (nodo == null)
                return new NodoABB(artista);

            if (string.Compare(artista.Nombre, nodo.Datos.Nombre) < 0)
                nodo.Izquierdo = InsertarRec(nodo.Izquierdo, artista);
            else
                nodo.Derecho = InsertarRec(nodo.Derecho, artista);

            return nodo;
        }

        public Artista Buscar(string nombre)
        {
            return BuscarRec(Raiz, nombre);
        }

        private Artista BuscarRec(NodoABB nodo, string nombre)
        {
            if (nodo == null)
                return null;

            int comparacion = string.Compare(nombre, nodo.Datos.Nombre);

            if (comparacion == 0)
                return nodo.Datos;
            else if (comparacion < 0)
                return BuscarRec(nodo.Izquierdo, nombre);
            else
                return BuscarRec(nodo.Derecho, nombre);
        }
    }
}

