using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Playlist> playlists = new List<Playlist>();

            Playlist Año2018 = new Playlist("Peliculas del 2018", "CHINGONAS");

            Playlist Año2019 = new Playlist("Peliculas del 2019", "AUN MAS CHINGONAS");

            playlists.Add(Año2018);
            playlists.Add(Año2019);
            Año2018.Peliculas.Add(new Pelicula("pelicula 1", 2018, "martin", "ficcion", "mexico", 180, 0, "pelicula muy bien en estructura y contenido"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 2", 2018, "david", "comedia", "australia", 150, 6, "dos hombres que se haen bromas hasta que uno madura"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 3", 2018, "un gringo", "infantil", "usa", 190, 8, "de los creadores de la era de hielo llega, los croods"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 4", 2018, "pedro", "ficcion", "usa", 170, 10, "guerra espacial, jamas bajan de la nave y de un planeta"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 5", 2018, "Johan", "romance", "francia", 180, 4, "el amor entre los hijos de dos mejores amigos se escucha normal pero tienes que verla para entenderlos"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 6", 2018, "Jesucristo", "documental", "USA", 190, 10, "te cuenta la vida de dios con personas dando testimonios"));
            Año2018.Peliculas.Add(new Pelicula("pelicula 7", 2018, "masiel", "accion", "mexico", 180, 9, "dos mejores amigos intentan matarse en una grandisima pelicula"));

            Año2019.Peliculas.Add(new Pelicula("pelicula 1", 2019, "martin", "ficcion", "mexico", 180, 0, "pelicula muy bien en estructura y contenido"));
            Año2019.Peliculas.Add(new Pelicula("pelicula 2", 2019, "david", "comedia", "australia", 150, 6, "dos hombres que se haen bromas hasta que uno madura"));
            Año2019.Peliculas.Add(new Pelicula("pelicula 3", 2019, "un gringo", "infantil", "usa", 190, 8, "de los creadores de la era de hielo llega, los croods"));
            Año2019.Peliculas.Add(new Pelicula("pelicula 4", 2019, "pedro", "ficcion", "usa", 170, 10, "guerra espacial, jamas bajan de la nave y de un planeta"));
            Año2019.Peliculas.Add(new Pelicula("pelicula 5", 2019, "Johan", "romance", "francia", 180, 4, "el amor entre los hijos de dos mejores amigos se escucha normal pero tienes que verla para entenderlos"));
            Año2019.Peliculas.Add(new Pelicula("pelicula 6", 2019, "Jesucristo", "documental", "USA", 190, 10, "te cuenta la vida de dios con personas dando testimonios"));



            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("\n\n ------------------------------------ \n\n");

                Console.WriteLine("\nNombre de la playlist: " + playlist.Titulo);
                Console.WriteLine("\nDescripcion: " + playlist.Descripcion);
                Console.WriteLine("\nLista de Peliculas:\n");

                //Console.WriteLine("");
                foreach (Pelicula pelicula in playlist.Peliculas)
                {


                    {
                        Console.WriteLine("\nTitulo: " + pelicula.Titulo + "\nDrirector: " + pelicula.Director + " Año: " + pelicula.Año +
                            "\nGenero: " + pelicula.Genero + "\nPais de origen : " + pelicula.Pais + "\nDuracion: " + pelicula.Duracion +
                            "\nRating: " + pelicula.Rating + "\nSinopsis: " + pelicula.Sinopsis);
                    }
                }
                Console.Read();
            }
        }


    }
}