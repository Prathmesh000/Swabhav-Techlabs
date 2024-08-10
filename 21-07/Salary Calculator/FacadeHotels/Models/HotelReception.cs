using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeHotels.GlobalInterfaces;

namespace FacadeHotels.Models
{
    internal class HotelReception
    {

        public HotelReception() { }

        public void GetIndianMenu()
        {
            IHotel indianHotel = new IndianHotel();
            IMenu menu = indianHotel.GetMenu();
            menu.DisplayMenu();
        }
        public void GetChineseMenu()
        {
            IHotel chineseHotel = new ChineseHotel();
            IMenu menu = chineseHotel.GetMenu();
            menu.DisplayMenu();
        }
        public void GetItalianMenu()
        {
            IHotel italianHotel = new ItalianHotel();
            IMenu menu = italianHotel.GetMenu();
            menu.DisplayMenu();
        }
    }
}
