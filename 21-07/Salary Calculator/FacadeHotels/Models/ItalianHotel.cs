using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeHotels.GlobalInterfaces;

namespace FacadeHotels.Models
{
    internal class ItalianHotel : IHotel
    {
       public IMenu GetMenu()
        {
            return new ItalianMenu();
        }
    }
}
