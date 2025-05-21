using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor_de_Musica
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public string Reproducciones { get; set; }
        public string UrlImagen { get; set; }
    }

    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UrlAudio { get; set; }
        public string UrlImagen { get; set; }
        public string Album { get; set; }
    }

}
