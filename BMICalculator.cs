using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCalculators
{
    class BMICalculator : BMIdata
    {
        public int status_code { get; set; }
        public string request_result { get; set; }
        public BMIdata data { get; set; }
    }
}
