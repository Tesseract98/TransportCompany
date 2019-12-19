using System.Collections.Generic;

namespace TransportCompany
{
    class CreateVehicles
    {
        public AllVehicles Create(string kindOf, double speed, double loadCapacity)
        {
            switch (kindOf.ToLower())
            {
                case "car":
                    return new Car(speed, loadCapacity);
                case "train":
                    return new Train(speed, loadCapacity);
                case "helicopter":
                    return new Helicopter(speed, loadCapacity);
                case "plane":
                    return new Plane(speed, loadCapacity);
                case "tanker":
                    return new Tanker(speed, loadCapacity);
                case "liner":
                    return new Liner(speed, loadCapacity);
            }
            throw new System.Exception("Not correct choose of vehicles");
        }
    }
}
