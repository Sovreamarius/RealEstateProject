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
            #region Variables
            bool quit = false;
            string first_selection = string.Empty; // used to select type of residence
            string second_selection = string.Empty; // used to decide if buy or not
            int third_selection = 0; // used to buy a specific apartment via ID
            
            #endregion

            #region Random lists for endowment

            List<Utilities> list1 = new List<Utilities>
            {
                Utilities.AC,
                Utilities.SmartUtilities,
                Utilities.View,
                Utilities.NoMousesInTheHouse
                //total : 8510
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

            //List of small apartments
            List<SmallApartment> smallApartments = new List<SmallApartment>
            {
                new SmallApartment(22,0,1,list3),
                new SmallApartment(205,2,1,list2),
                new SmallApartment(103,1,1,list1)
            };

            //List of studios
            List<Studio> studios = new List<Studio>
            {
                new Studio(11,0,1,list3),
                new Studio(215,2,1,list2),
                new Studio(123,1,1,list1)
            };

            #endregion

            #region Menu 
            
            while (!quit)
            {
                PrintMenu();
                
                first_selection = Console.ReadLine();
                //Choose what type of residence to buy
                switch (first_selection)
                {
                    case "1":
                        Console.Clear();

                        //to be modified
                        List<int> apartmentIDs = new List<int>();

                        foreach (var apartment in apartments)
                        {
                            apartmentIDs.Add(apartment.Id);
                            apartment.ShowInfo();
                        }

                        Console.WriteLine("1 - Buy, 2 - Back");
                        second_selection = Console.ReadLine();
                        
                        switch (second_selection)
                        {
                            case "1":
                                Console.WriteLine("Select which apartment you want to buy. (write ID)");
                                third_selection = Convert.ToInt32(Console.ReadLine());

                                foreach (var apId in apartmentIDs)
                                {
                                    if (third_selection == apId)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You bought apartment with Id: " + apId);
                                        foreach (var apart in apartments)
                                        {
                                            if (apart.Id == apId)
                                            {
                                                apart.ShowInfo();

                                                bool addMore = true;
                                                while (addMore)
                                                {
                                                    Console.WriteLine("Add endowment or exit(e)");
                                                    Console.WriteLine("AC(1), View (2), Gas(3), SmartUtilities(4), NoMousesInTheHouse(5)");
                                                    string str = Console.ReadLine();
                                                    switch (str)
                                                    {
                                                        case "1":
                                                            apart.Endowment.Add(Utilities.AC);
                                                            break;
                                                        case "2":
                                                            apart.Endowment.Add(Utilities.View);
                                                            break;
                                                        case "3":
                                                            apart.Endowment.Add(Utilities.Gas);
                                                            break;
                                                        case "4":
                                                            apart.Endowment.Add(Utilities.SmartUtilities);
                                                            break;
                                                        case "5":
                                                            apart.Endowment.Add(Utilities.NoMousesInTheHouse);
                                                            break;
                                                        case "e":
                                                        default:
                                                            addMore = false;
                                                            break;
                                                    }
                                                }
                                                Console.Clear();
                                                apart.ShowInfo();
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                }
                                
                                Console.ReadKey();
                                break;
                            case "2":
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        foreach (var house in houses)
                        {
                            Console.WriteLine("ID: "+house.Id);
                            house.ShowInfo();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        foreach (var smallAp in smallApartments)
                        {
                            smallAp.ShowInfo();
                        }
                        break;
                    case "4":
                        Console.Clear();
                        foreach (var studio in studios)
                        {
                            studio.ShowInfo();
                        }
                        break;
                    case "e":
                        quit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please choose a correct value."); ;
                        break;
                }
            }
            #endregion

        }

        #region Private helpers

        private static void PrintMenu()
        {
            Console.WriteLine("Choose what you want to buy\n");
            Console.WriteLine("Apartments (1)");
            Console.WriteLine("Houses (2)");
            Console.WriteLine("SmallApartments (3)");
            Console.WriteLine("Studios (4)");
            Console.WriteLine("Exit (e)\n");
        }

        #endregion
    }
}
