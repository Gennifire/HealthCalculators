using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCalculators
{
    class IdealWeightData
    {

        public double Hamwi { get; set; }
        public double Devine { get; set; }
        public double Miller { get; set; }
        public double Robinson { get; set; }

        public override string ToString()
        {
            //Overrides and returns a string that represents the current object.
            string text = null;
            text += "Using Hamwi Formula: " + Hamwi + "\r\n";
            text += "Using Devine Formula: " + Devine + "\r\n";
            text += "Using Miller Formula: " + Miller + "\r\n";
            text += "Using Robinson Formula: " + Robinson + "\r\n\r\n";

            //gave average of all results to give user a middle line
            double resultAvg = (Hamwi + Devine + Miller + Robinson) / 4;
            text += "Average of these = " + (Math.Round(resultAvg, 2));

            return text;
        }
    }
}
