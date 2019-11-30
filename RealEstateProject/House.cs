using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class House : Residence
    {
        public int Level { get; set; }
        public override double Surface { get => 120; set => Surface = value; }

        public House(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment, int _level) : base(_number, _floor, _balconiesNo, _endowment)
        {
            Level = _level;
        }

        // if the level of house is 2 then the price is doubled
        public override double GetTotalPrice()
        {
            if (Level == 2)
                return Surface * 1000 * 2;
            else
                return Surface * 1000;
        }
    }
}
