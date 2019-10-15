using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        public string Name;
        public string RegNo;
        public List<double> speeds = new List<double> { };

        public Vehicle(string vehicleName, string regNo)
        {
            this.Name = vehicleName;
            this.RegNo = regNo;

        }


        public double SetSpeed(double speed)
        {
            speeds.Add(speed);
            return speed;
        }

        public double MaxSpeed()
        {
            double MaxSpeed = speeds.Max();
            return MaxSpeed;

        }


        public double MinSpeed()
        {
            double MinSpeed = speeds.Min();
            return MinSpeed;

        }

        public double AvgSpeed()
        {
            double AvgSpeed = speeds.Average();
            return AvgSpeed;
        }

    }
}
