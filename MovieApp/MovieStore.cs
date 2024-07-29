using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieClasses.Models;

namespace MovieProject
{
    internal class MovieStore
    {
        public void Start()
        {
            MovieManager movieManager = new MovieManager();
            Console.WriteLine("-------------------------------------------------------Welcome---------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            int count = MovieManager.list.Count;
            Console.WriteLine($"Total Movies Available: " + count);

            char userChoice = 'y';
            while (userChoice == 'y' || userChoice == 'Y')
            {
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display Movie List");
                Console.WriteLine("3. Delete Movie");
                Console.WriteLine("4. Exit");
                Console.WriteLine("What would you like to do???");
                int selectOperation = int.Parse(Console.ReadLine());

                switch (selectOperation)
                {
                    case 1:
                        movieManager.AddMovie();
                        break;
                    case 2:
                        movieManager.DisplayMovieList();
                        break;
                    case 3:
                        movieManager.DeleteMovie();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Select valid option");
                        break;
                }

                Console.WriteLine("Do you want to continue Y/N ??");
                userChoice = char.Parse(Console.ReadLine());
            }
        }
    }
}
