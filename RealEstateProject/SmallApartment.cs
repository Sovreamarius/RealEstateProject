using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class SmallApartment : Residence
    {
        public override double Surface { get => 40; set => Surface = value; }

        public SmallApartment(int _number, int _floor, int _balconiesNo, List<String> _endowment) : base(_number, _floor, _balconiesNo, _endowment)
        {}
    }
}
