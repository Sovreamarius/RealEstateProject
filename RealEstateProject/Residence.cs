using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Residence : IHelper
    {
        // List<string> _endowment = new List<string> { "AC", "View", "Gas", "Smart utilities" };

        public int Number { get; set; }
        public int Floor { get; set; }
        public int BalconiesNo { get; set; }
        public virtual double Surface { get; set; }

        public enum Utilities {
            AC = 500,
            View = 5000,
            Gas = 1000,
            SmartUtilities = 3000
        } 

        public List<Utilities> Endowment { get; set; } 

        #region Constructors

        //default constructor
        public Residence()
        { }

        //without surface - used in derived class to have a specific surface
        public Residence(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment)
        {
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Endowment = _endowment;
        }

        //used to create object of Residence with all the content
        public Residence(int _number, int _floor, int _balconiesNo, double _surface, List<Utilities> _endowment)
        {
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Surface = _surface;
            Endowment = _endowment;
        }

        #endregion

        public virtual double GetTotalPrice()
        {
            return Surface * 1000;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine(
                "Surface: {0}, Number: {1}, Floor: {2}, BalconiesNo: {3}, Price: {4}",
                Surface, Number, Floor, BalconiesNo, GetTotalPrice());
            foreach (var item in Endowment)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
