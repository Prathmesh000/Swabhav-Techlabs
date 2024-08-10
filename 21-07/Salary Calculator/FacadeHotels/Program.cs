

using FacadeHotels.Models;

public class Program
{
    public static void Main(string[] args)
    {
        HotelReception hotelReception = new HotelReception();
        hotelReception.GetItalianMenu();
        hotelReception.GetIndianMenu();
        hotelReception.GetChineseMenu();

    }
}