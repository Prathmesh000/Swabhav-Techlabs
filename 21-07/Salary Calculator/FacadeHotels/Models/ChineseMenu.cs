using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeHotels.GlobalInterfaces;

namespace FacadeHotels.Models
{
    internal class ChineseMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("This is Chinese Menu");
        }
    }
}
