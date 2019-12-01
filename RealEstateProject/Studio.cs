using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Studio : Residence
    {
        #region Properties

        public override double Surface { get => 50; set => base.Surface = value; }

        #endregion

        #region Constructors

        public Studio() { }

        public Studio(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment) : base(_number, _floor, _balconiesNo, _endowment) { }

        #endregion
    }
}
