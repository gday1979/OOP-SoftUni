using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Structure.CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        public ProfessionalRacer(string username, ICar car) : base(username, "strict", 30, car)
        {
        }
    }
}
