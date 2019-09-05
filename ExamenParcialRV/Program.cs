using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcialRV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Playlists> playlists = new List<Playlists>();
            Playlists comedia = new Playlists(" Comedia ");
            comedia.Titulo = " Diversion ";
            comedia.Descripcion = "Moriras de risa";

            comedia.Peli.Add(new Peliculas("Nosotros los nobles", 2011));
            comedia.Peli.Add(new Peliculas("Mala", 2010 ));
            comedia.Peli.Add(new Peliculas("Estudiante", 2011 ));
            comedia.Peli.Add(new Peliculas("Bastardo sin gloria", 2017 ));
            comedia.Peli.Add(new Peliculas("Como si fuera la ultima vez", 2013 ));
            comedia.Peli.Add(new Peliculas("Como si fuera la primera vez", 2014));
            comedia.Peli.Add(new Peliculas("Mama",2000 ));

            Playlists romance = new Playlists("Romance");
            romance.Titulo = " Amor";
            romance.Descripcion = ("Moriras de amor");
            romance.Peli.Add(new Peliculas("Yo antes de ti", 2016));
            romance.Peli.Add(new Peliculas("Love Rosie", 2010));
            romance.Peli.Add(new Peliculas("Nunca me olvides", 2007));
            romance.Peli.Add(new Peliculas("Mejores amigos", 2005));
            romance.Peli.Add(new Peliculas("500 dias con ella", 2008));
            romance.Peli.Add(new Peliculas("High School Musical", 2006));
            romance.Peli.Add(new Peliculas("Amor Amor", 2003));

            playlists.Add(comedia);
            playlists.Add(romance);

            foreach (Playlists playlist in playlists)
            {
                Console.WriteLine("*" + playlist.Titulo + " descripcion: "  + playlist.Descripcion);
                foreach(Peliculas peliculas in playlist.Peli                                                              )
                {
                    Console.WriteLine("-" + peliculas.Titulo + " " + peliculas.Año);
                }
            }
            Peliculas peliculass = new Peliculas();
            try
            {
                peliculass.Año = 2018;
            }
            catch(Exception e)
            {
                Console.WriteLine(" No se estreno en fecha valida");
            }

           
        try
            {
                peliculass.Duracion = 59;
            }
            catch(Exception e)
            {
                Console.WriteLine(" No es duracion valida");
            }
            try
            {
                peliculass.Rating = 9;
            }
            catch (Exception e)
            {
                Console.WriteLine(" No es rating valido");
            }

           

        Console.Read();
            }
        }
    }

