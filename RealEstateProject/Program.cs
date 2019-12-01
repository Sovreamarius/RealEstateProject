using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RealEstateProject.Residence;

namespace RealEstateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random lists for endowment

            List<Utilities> list1 = new List<Utilities>
            {
                Utilities.AC,
                Utilities.SmartUtilities,
                Utilities.View,
                Utilities.NoMousesInTheHouse
            };

            List<Utilities> list2 = new List<Utilities>
            {
                Utilities.AC,
                Utilities.NoMousesInTheHouse
            };

            List<Utilities> list3 = new List<Utilities>
            {
                Utilities.AC,
                Utilities.SmartUtilities,
            };
            #endregion

            #region Lists of objects
            // List of apartments on sale
            List<Apartment> apartments = new List<Apartment>
            {
                new Apartment(2, 0, 1, list1, 2),
                new Apartment(56, 0, 1, list1, 4),
                new Apartment(102, 1, 1, list2, 3),
                new Apartment(302, 3, 1, list3, 2),
                new Apartment(217, 2, 1, list3, 3),
                new Apartment(427, 4, 1, list2, 4)
            };

            // List of houses on sale
            List<House> houses = new List<House>
            {
                new House(27, 0, 1, list2, 2),
                new House(16, 0, 2, list2, 2),
                new House(12, 0, 1, list3, 1),
                new House(402, 0, 3, list1, 1),
                new House(127, 0, 1, list1, 1),
                new House(55, 0, 1, list2, 1)
            };
            #endregion

            #region Menu 
            Console.WriteLine("Choose what you wanna buy: 1 - apartments, 2 - houses \n");
            string selection = string.Empty;
            selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    Console.WriteLine("Ti-o trebuit tie apartamente...no cauta...\n");
                    foreach (var apartment in apartments)
                    {
                        apartment.ShowInfo();
                    }
                    break;
                case "2":
                    Console.WriteLine("Ti-o trebuit tie case...no cauta...\n");
                    foreach (var house in houses)
                    {
                        house.ShowInfo();
                    }
                    break;
                default:break;
            }
            #endregion

            Console.ReadKey();
        }
    }
}
