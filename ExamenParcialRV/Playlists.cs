using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialRV
{
    class Playlists
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List <Peliculas>Peli { get; set; }

        public Playlists()
        {
            Titulo = "Pelicula nueva";
            Descripcion = "Sin asignar";
            Peli = new List<Peliculas>();

        }
        public Playlists(string titulo)
        {
            Titulo = titulo;
            Descripcion = "Sin asignar";
            Peli = new List<Peliculas>();
        }

        
    }
}
