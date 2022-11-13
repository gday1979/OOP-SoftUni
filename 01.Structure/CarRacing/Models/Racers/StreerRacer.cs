using CarRacing.Models.Racers;
using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using _01.Structure.CarRacing.Models.Racers;

namespace CarRacing.Models.Racers
{
    public class StreerRacer : Racer
    {
        public StreerRacer(string username, ICar car) : base(username,"aggressive",10, car)
        {
        }
    }
}
