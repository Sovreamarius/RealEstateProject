using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Residence
    {
        #region Fields and Properties
        protected const int costMultiplier = 1000;
        public int _totalEndowmentCost = 0; // the utilities cost for the specific residence
        public int _totalCost = 0; //total cost of the residence
        private static int id; // id for each instance

        public int Id { get; private set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int BalconiesNo { get; set; }
        public virtual int Surface { get; set; }
       
        public enum Utilities {
            AC = 500,
            View = 5000,
            Gas = 1000,
            SmartUtilities = 3000,
            NoMousesInTheHouse = 10
        }
        
        public List<Utilities> Endowment { get; set; }

        #endregion

        #region Constructors

        //default constructor
        public Residence() { }

        //without surface - used in derived class to have a specific surface
        public Residence(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment)
        {
            Id = Interlocked.Increment(ref id); 
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Endowment = _endowment;
        }

        //used to create object of Residence with all the content
        public Residence(int _number, int _floor, int _balconiesNo, int _surface, List<Utilities> _endowment)
        {
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Surface = _surface;
            Endowment = _endowment;
        }

        #endregion

        #region Methods

        #region public methods
        
        public virtual void ShowInfo()
        {
            Console.WriteLine("=========== ID: "+ Id +"===========");
            Console.WriteLine("Number: {0} \n" + "Floor: {1} \n" + "Balconies: {2} \n" + "Surface: {3} \n" + "Price by surface: {4} \n" + "Type: {5}",
                 Number, Floor, BalconiesNo, Surface, GetTotalPrice(), GetType());
            Console.WriteLine("This residence has to following endowment:");
            int count = 0;
            foreach (var item in Endowment)
            {
                count++;
                Console.WriteLine(count + " - " + item.ToString() +" which costs: " + (int)item);
            }
            Console.WriteLine("Utilities total cost: " + CalculateUtilitiesPrice());
           // _totalCostCalculed = false;
            Console.WriteLine("Total Price: " + GetTotalPrice() + "\n");
            ResetCosts();
        }

        #endregion

        #region protected&private methods
        //to be changed later in private and add it in all derived class somehow
        protected int CalculateUtilitiesPrice()
        {
            foreach (var item in Endowment)
            {
                int val = (int)item;
                _totalEndowmentCost += val;
            }
            return _totalEndowmentCost;
        }

        protected virtual int GetTotalPrice()
        {
            _totalCost = Surface * costMultiplier + _totalEndowmentCost;
            return _totalCost;
        }

        protected void ResetCosts()
        {
            _totalCost = 0;
            _totalEndowmentCost = 0;
        }
        #endregion

        #endregion
    }
}
