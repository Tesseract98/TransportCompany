using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Train : GroundTransport
    {
        private string className = "Train";
        public Train(double speed, double loadCapacity)
        {
            maxSpeed = 580.5;
            maxNumberOfStaff = 60;
            maxNumberOfPassengers = 1100;
            maxLoadCapacity = 250000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;     
        }
    }
}