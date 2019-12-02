using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Apartment : Residence
    {
        #region Fields and Properties

        private int noOfRooms = 0;
        public int NoOfRooms
        {
            get { return noOfRooms; }
            set
            {
                if (value < 1 || value > 4)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 4.");
                else
                    noOfRooms = value;
            }
        }

        public override int Surface {
            get
            {
                if (NoOfRooms == 2)
                {
                    return 60;
                }
                else if (NoOfRooms == 3)
                {
                    return 80;
                }
                else if (NoOfRooms == 4)
                {
                    return 100;
                }
                else
                {
                    return 0;
                }
            }
            set => Surface = value; }

        #endregion

        #region Constructor

        public Apartment() { }

        public Apartment(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment, int _noOfRooms) : base(_number, _floor, _balconiesNo, _endowment)
        {
            NoOfRooms = _noOfRooms;
        }

        #endregion

        #region Methods

        public override void ShowInfo()
        {
            Console.WriteLine("=========== ID: " + Id + "===========");
            Console.WriteLine(
                "Number: {0} \n" + "Floor: {1} \n" + "Balconies: {2} \n" + "Surface: {3} \n" + "Rooms: {4} \n" + "Price without utilities: {5} \n" + "Type: {6}",
                 Number, Floor, BalconiesNo, Surface, NoOfRooms, GetTotalPrice(), GetType());
            Console.WriteLine("This residence has to following endowment:");
            int count = 0;
            foreach (var item in Endowment)
            {
                count++;
                Console.WriteLine(count + " - " + item.ToString() + " which costs: " + (int)item);
            }
            Console.WriteLine("Utilities total cost: " + CalculateUtilitiesPrice());
            Console.WriteLine("Total Price: " + GetTotalPrice() + "\n");
            ResetCosts();
        }

        #endregion
    }
}
