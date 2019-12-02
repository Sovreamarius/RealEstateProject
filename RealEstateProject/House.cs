using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class House : Residence
    {
        #region Fields and Properties

        private int level = 0;
        public int Level { get { return level; }
            set
            {
                if (value < 1 || value > 2)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be 1 or 2.");
                }
                else
                {
                    level = value;
                }
            }
        }
        public override int Surface { get => 120; set => Surface = value; }

        #endregion

        #region Constructors

        public House() { }

        public House(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment, int _level) : base(_number, _floor, _balconiesNo, _endowment)
        {
            Level = _level;
        }

        #endregion

        #region Methods

        // if the level of house is 2 then the price is doubled
        public override int GetTotalPrice()
        {
            if (Level == 2)
                return (Surface * 1000 + _totalEndowmentCost) * 2;
            else
                return Surface * 1000 + _totalEndowmentCost;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=========== ID: " + Id + "===========");
            Console.WriteLine(
                "Number: {0} \n" + "Floor: {1} \n" + "Balconies: {2} \n" + "Surface: {3} \n" + "Level: {4} \n" + "Price without utilities: {5} \n" + "Type: {6}",
                 Number, Floor, BalconiesNo, Surface, Level, GetTotalPrice(), GetType());
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
