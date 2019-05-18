using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    abstract class AirTransport : AllVehicles
    {
        private string errorMessage = "\ninvalid value\n";
        private double speed = 0;
        private double loadCapacity = 0;
        private int numberOfStaff = 0;
        private int numberOfPassengers = 0;
        private double stuff = 0;
        protected string name = "";
        protected double maxSpeed = 0;
        protected double maxLoadCapacity = 0;
        protected int maxNumberOfStaff = 0;
        protected int maxNumberOfPassengers = 0;
        public double CheckCapacity
        {
            get
            {
                return stuff;
            }
            set
            {
                if (stuff + value < loadCapacity)
                {
                    stuff += value;
                }
                else
                {
                    throw new System.Exception(errorMessage);
                }
            }
        }
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < maxSpeed)
                {
                    speed = value;
                }
                else
                {
                    throw new System.Exception(errorMessage);
                }
            }
        }
        public double LoadCapacity
        {
            set
            {
                if (value < maxLoadCapacity)
                {
                    loadCapacity = value;
                }
                else
                {
                    throw new System.Exception(errorMessage);
                }
            }
            get
            {
                return loadCapacity;
            }
        }
        public string Brand { set; get; } = "";
        public int NumberOfStaff
        {
            set
            {
                if (value < maxNumberOfStaff)
                {
                    numberOfStaff = value;
                }
                else
                {
                    throw new System.Exception(errorMessage);
                }
            }
            get
            {
                return numberOfStaff;
            }
        }
        public int NumberOfPassengers
        {
            set
            {
                if (value < maxNumberOfPassengers)
                {
                    numberOfPassengers = value;
                }
                else
                {
                    throw new System.Exception(errorMessage);
                }
            }
            get
            {
                return numberOfPassengers;
            }
        }
        public void GetInformation()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Speed " + speed);
            Console.WriteLine("Load capacity " + loadCapacity);
            Console.WriteLine("Brand " + Brand);
            Console.WriteLine("Number of staff " + numberOfStaff);
            Console.WriteLine("Number of passengers " + numberOfPassengers);
        }
    }
}