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

        public House(int _number, int _floor, int _balconiesNo, List<String> _endowment, int _level) : base(_number, _floor, _balconiesNo, _endowment)
        {
            Level = _level;
        }
    }
}
