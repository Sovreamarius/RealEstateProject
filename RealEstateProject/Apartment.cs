﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProject
{
    public class Apartment : Residence
    {
        private int noRooms = 0;
        public int NoOfRooms
        {
            get { return noRooms; }
            set
            {
                if (value < 1 || value > 4)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 4.");
                else
                    noRooms = value;
            }
        }

        public override double Surface {
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

        public Apartment() { }

        public Apartment(int _number, int _floor, int _balconiesNo, List<Utilities> _endowment, int _noOfRooms) : base(_number, _floor, _balconiesNo, _endowment)
        {
            NoOfRooms = _noOfRooms;
        }
    }
}
