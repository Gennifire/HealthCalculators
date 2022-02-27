using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCalculators
{
    class IdealWeightCalculation : IdealWeightData
    {
        public int status_code { get; set; }
        public string request_result { get; set; }
        public IdealWeightData data { get; set; }
    }
}
