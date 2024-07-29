using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClasses.Models
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int YearOfRelease { get; set; }

        public Movie() { }
        public Movie(string movieName, string movieGenre, int yearOfRelease) : this(movieName, movieGenre, yearOfRelease, "")
        {

        }
        public Movie(string movieName, string movieGenre, int yearOfRelease, string movieId)
        {
            MovieId = movieName.Substring(0, 2) + movieGenre.Substring(0, 2) + (yearOfRelease % 100).ToString("D2");
            MovieName = movieName;
            MovieGenre = movieGenre;
            YearOfRelease = yearOfRelease;

        }
    }
}
