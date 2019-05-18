using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class Car : GroundTransport
    {
        private string className = "Car";
        public Car(double speed, double loadCapacity)
        {
            maxSpeed = 150.5;
            maxNumberOfStaff = 3;
            maxNumberOfPassengers = 5;
            maxLoadCapacity = 600;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;     
        }     
    }
}
