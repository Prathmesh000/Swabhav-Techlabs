using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClasses.Global_Exception_Handler
{
    public class MovieListFullException : Exception
    {
        public MovieListFullException(string str) : base(str) { }
        
    }
}
