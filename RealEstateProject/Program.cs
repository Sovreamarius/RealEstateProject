using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> endowment = new List<string> { "AC", "View", "Gas", "Smart utilities" };

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
            */

            Apartment ap1 = new Apartment(23,2,12,endowment,4);


            SmallApartment smap1 = new SmallApartment(1, 1, 1, endowment);
            Console.WriteLine("small apartment surface: {0}", smap1.Surface);

            Studio studio1 = new Studio(2,3,12,endowment);
            Console.WriteLine("studio surface: {0}", studio1.Surface);
            Console.WriteLine("Price is: " + studio1.GetTotalPrice());
        

            Console.ReadKey();
        }
    }
}
