using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieClasses.Global_Exception_Handler;
using MovieClasses.SerializationDeserialization;

namespace MovieClasses.Models
{
    public class MovieManager
    {
          public static List<Movie> list = new List<Movie>();

        public MovieManager() {
            list = SerializingDeserializing.Deserialize();
        }
           

        public void AddMovie()
        {
            //List<Movie> list = MoviesList();
            int movieCount = list.Count;
            

            try
            {
                if (movieCount < 5)
                {
                    Console.WriteLine("Enter Movie Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Movie Genre: ");
                    string genre = Console.ReadLine();

                    Console.WriteLine("Enter Movies Year of Release: ");
                    int releaseYear = int.Parse(Console.ReadLine());

                    list.Add(new Movie(name, genre, releaseYear));
                    SerializingDeserializing.Serialize(list);
                    Console.WriteLine("Movie Added Successfully");
                    movieCount++;
                }
                else
                {
                    throw new MovieListFullException("Movie List is Full");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void DisplayMovieList()
        {
            //List<Movie> list = MoviesList();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"| {"Movie Id", -10} | {"Movie Name", -17} | {"Movie Genre", -12} | {"Year of Release", -16} |");
                Console.WriteLine("--------------------------------------------------------------------");

            foreach (Movie movie in list)
            {
                Console.WriteLine($"| {movie.MovieId, -10} | {movie.MovieName, -17} | {movie.MovieGenre, -12} | {movie.YearOfRelease, -16} |");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
        public void DeleteMovie()
        {
            //List<Movie> list = MoviesList();
            Console.WriteLine("Enter MovieId of Movie you want to delete: ");
            string deleteMovieId = Console.ReadLine();

            //foreach (Movie movie in list)
            //{
            //    if(movie.MovieId == deleteMovieId)
            //    {
            //        list.Remove(movie);
            //    }
            //}
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MovieId == deleteMovieId)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("Movie Deleted Successfully");
                    flag = true;
                }

                SerializingDeserializing.Serialize(list);
            }
            if (!flag)
            {
                Console.WriteLine("Account Not Found");
            }

        }

    }
}
