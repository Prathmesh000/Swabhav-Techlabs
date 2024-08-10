using System.ComponentModel;
using ConsoleApp1.Models;


namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            GuitarSpecs whatErinLikes = new GuitarSpecs(Builder.Any, null, Models.Type.Electric, Wood.Alder, Wood.Alder, 6);
            List<Guitar> matchingGuitars = inventory.SearchGuitar(whatErinLikes);
            if (matchingGuitars.Count > 0)
            {
                Console.WriteLine("Erin, you might like these guitars:");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine($"|{"Builder",-10} | {"Model",-15} | {"Type",-10} | {"BackWood",-10} | {"TopWood",-10} | {"No. of Strings",-15} | {"Price",-8}|");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                foreach (var guitar in matchingGuitars)
                {

                    Console.WriteLine($"|{guitar.Spec.Builder,-10} | {guitar.Spec.Model,-15} | {guitar.Spec.Type,-10} | {guitar.Spec.BackWood,-10} | {guitar.Spec.TopWood,-10} | {guitar.Spec.NumberOfStrings,-15} | {guitar.Price,-8}|");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine(" Erin, we have nothing for u.");
            }
        }

        private static void InitializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("1", 4000, new GuitarSpecs(Builder.Collings, "CJ", Models.Type.Accoustic, Wood.IndianRosewood, Wood.Sitka, 6));
            inventory.AddGuitar("2", 1500, new GuitarSpecs(Builder.Fender, "Stratocaster", Models.Type.Electric, Wood.Alder, Wood.Alder, 6));
            inventory.AddGuitar("3", 1149.50, new GuitarSpecs(Builder.Gibson, "Stratocaster", Models.Type.Accoustic, Wood.Alder, Wood.Alder, 6));
            inventory.AddGuitar("4", 2000, new GuitarSpecs(Builder.Ryan, "Random", Models.Type.Electric, Wood.Alder, Wood.Alder, 6));
        }
    }

}