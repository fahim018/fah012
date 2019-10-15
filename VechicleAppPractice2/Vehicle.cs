using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
   public class Vehicle
   {
       private string vehicleName;
       private int registrationno;
        public Vehicle(string vehiclename, int regno)
        {
            this.vehicleName= vehiclename;
            this.registrationno = regno;
        }
        public string vehiclename { set; get; }
        public int reno { set; get; }
        public  List<Double> speed = new List<double>();

        public double GetMax()
        {
            double max = speed.Max();
            return max;
        }
        public double GetMin()
        {
            double min = speed.Min();
            return min;
        }
        public double GetAvg()
        {
            double avg = speed.Average();
            return avg;
        }
    }
}
