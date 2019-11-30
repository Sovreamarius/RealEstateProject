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
        public List<string> Endowment { get; set; } 

        #region Constructors

        //default constructor
        public Residence()
        { }

        //without surface - used in derived class to have a specific surface
        public Residence(int _number, int _floor, int _balconiesNo, List<String> _endowment)
        {
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Endowment = _endowment;
        }

        //used to create object of Residence with all the content
        public Residence(int _number, int _floor, int _balconiesNo, double _surface, List<String> _endowment)
        {
            Number = _number;
            Floor = _floor;
            BalconiesNo = _balconiesNo;
            Surface = _surface;
            Endowment = _endowment;
        }

        #endregion

        public double GetTotalPrice()
        {
            return Surface * 1000;
        }
    }
}
