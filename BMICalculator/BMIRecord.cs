using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BMIRecord
    {
        public string DateRecorded {  get; set; }
        public double Weight { get; set;}
        public double BMIResult { get; set; }
        public string BMIStatus { get; set; }
    }
}
