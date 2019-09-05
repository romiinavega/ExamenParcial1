using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialRV
{
    class Peliculas
    {
        public string Titulo { get; set; }
        private int _año;
        public int Año
        { get
            {
                return _año;
            }
            set
            {
                if (value >1800 && value <= 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception ("No se estreno en fecha valida");
                }
            }
        }
        public string Director { get; set; }
        public string Pais { get; set; }
        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
                 set
            {
                if (value > 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("No es numero valido");
                }
            }
        }
        private double _rating;
        public double Rating {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("No es rating valido");
                }
            }
        }
        public string Sinopsis { get; set; }
        public string Genero { get; set; }

        public Peliculas()
        {
            Titulo = "Sin Título";
            Director = "Sin Director";
            Genero = "Sin Asignar";
            Pais = "Sin País";
            Sinopsis = "Sin Sinopsis";
        }
        public Peliculas(string titulo, int año)
        {
            Titulo = titulo;
            Año = año;
        }
            public Peliculas(string titulo, int año, string director, string genero, string pais, string sinopsis, int duracion, double rating)
            {
                Titulo = titulo;
            Año = año;
                Director = director;
                Genero = genero;
                Pais = pais;
               Sinopsis = sinopsis;
            Duracion = duracion;
            Rating = rating;

            }

        

    }
}
