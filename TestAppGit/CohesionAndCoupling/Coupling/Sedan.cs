﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Sedan : Car
    {
        public string SecondCollor; 
        public Sedan(Car car,double engineVolum) : base(engineVolum)
        {
            SecondCollor = car.Colour;
        }

    }
}
