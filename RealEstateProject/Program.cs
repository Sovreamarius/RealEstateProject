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
            // List<string> endowment = new List<string> { "AC", "View", "Gas", "Smart utilities" };

            /*House h1 = new House(124, 2, 1, 50, endowment, 1);
            House h2 = new House(0, 0, 0, 700, endowment, 2);
            Studio s1 = new Studio(1,2,1,40, endowment);


            Console.WriteLine("h1 endowment 2: "+ h1.Endowment[1]);
            Console.WriteLine("h2 surface: "+ h2.Surface);
            Console.WriteLine("s1 endowment: " + s1.Endowment[3]);
            Apartment ap = new Apartment(12, 2, 2, 59, endowment,3);
            SmallApartment smallAp = new SmallApartment(12,1,1,40,endowment);
            Residence r1 = new Residence(1, 1, 1, endowment);
            House h1 = new House(12,2,2,endowment,2);
            Console.WriteLine("r1 surface "+r1.Surface);
            Console.WriteLine("house surface: " + h1.Surface); 
            
            House h1 = new House(2, 2, 2, endowment, 1);
            Console.WriteLine("surface of house "+h1.Surface);
            Console.WriteLine("price of house: "+h1.GetTotalPrice());
            */
            /*
            Apartment ap1 = new Apartment(23,2,12,endowment,4);


            SmallApartment smap1 = new SmallApartment(1, 1, 1, endowment);
            Console.WriteLine("small apartment surface: {0}", smap1.Surface);

            Studio studio1 = new Studio(2,3,12,endowment);
            Console.WriteLine("studio surface: {0}", studio1.Surface);
            Console.WriteLine("Price is: " + studio1.GetTotalPrice());
            */
            //Apartment ap1 = new Apartment();
            // ap1.NoOfRooms = 3;
            //  Console.WriteLine(""+ ap1.NoOfRooms);

            /*
            var houses = new List<House>();
            var house1 = new House(23, 3, 1, endowment, 2);
            var house2 = new House(27, 3, 1, endowment, 1);
            houses.Add(house1);
            houses.Add(house2);

            int count = 0;
            foreach (var item in houses)
            {
                count++;
                Console.WriteLine("House nr. " + count);
                Console.WriteLine(
                    "Surface: {0}, Number: {1}, Floor: {2}, BalconiesNo: {3}, Level: {4}, Price: {5}",
                    item.Surface , item.Number, item.Floor, item.BalconiesNo, item.Level, item.GetTotalPrice()
                    );
            }*/
            
            List<Utilities> list = new List<Utilities>();
            list.Add(Utilities.AC);
            list.Add(Utilities.SmartUtilities);
            list.Add(Utilities.SmartUtilities);

            Apartment ap1 = new Apartment(12, 2, 1,list, 3);

            ap1.ShowInfo();

            Console.ReadKey();
        }
    }
}
