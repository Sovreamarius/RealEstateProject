using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Studio : Residence
    {
        public override double Surface { get => 50; set => base.Surface = value; }

        public Studio(int _number, int _floor, int _balconiesNo, List<String> _endowment) : base(_number, _floor, _balconiesNo, _endowment)
        { }
    }
}
