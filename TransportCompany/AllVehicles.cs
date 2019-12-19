using System;

namespace TransportCompany
{
    abstract class AllVehicles
    {
        protected string errorMessage = "\ninvalid value\n";
        protected double speed = 0;
        protected double loadCapacity = 0;
        protected int numberOfStaff = 0;
        protected int numberOfPassengers = 0;
        protected double stuff = 0;
        protected string name = "";
        protected double maxSpeed = 0;
        protected double maxLoadCapacity = 0;
        protected int maxNumberOfStaff = 0;
        protected int maxNumberOfPassengers = 0;
        public void GetInformation()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Speed " + speed);
            Console.WriteLine("Load capacity " + loadCapacity);
            //Console.WriteLine("Brand " + Brand);
            //Console.WriteLine("Number of staff " + numberOfStaff);
            //Console.WriteLine("Number of passengers " + numberOfPassengers);
        }
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
    }
}