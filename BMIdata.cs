using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCalculators
{
    class BMIdata
    {
        public double bmi { get; set; }
        public string health { get; set; }
        public string healthy_bmi_range { get; set; }
        public int age { get; set; }
        public int height { get; set; }
        public int weight { get; set; }


        public override string ToString()
        {
            //Overrides and returns a string that represents the current object.
            string text = null;
            text += "Your " + bmi + "\r\n";
            text += "This is considered " + health + "\r\n";
            text += "Health Bmi range = " + healthy_bmi_range;

            return text;
        }
    }

    
}
