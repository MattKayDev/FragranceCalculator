using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragranceCalculator.Services
{
    public static class Calculator
    {
        public static double TotalWaxWeight(double vesselFill, int numberOfVessels)
        {
            return vesselFill * numberOfVessels;
        }

        public static double TotalFragranceWeight(double fragranceWeight, int numberOfVessels)
        {
            return fragranceWeight * numberOfVessels;
        }

        public static double WaxPerVessel(double vesselFill, int percentage)
        {
            return vesselFill - (vesselFill / 100 * percentage);
        }
        public static double FragrancePerVessel(double vesselFill, int percentage)
        {
            return vesselFill / 100 * percentage;
        }
        
    }
}
