using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    class CreateVehicles
    {
        public AllVehicles Create(int kindOf, double speed, double loadCapacity)
        {
            switch (kindOf)
            {
                case 1:
                    return new Car(speed, loadCapacity);
                case 2:
                    return new Train(speed, loadCapacity);
                case 3:
                    return new Helicopter(speed, loadCapacity);
                case 4:
                    return new Plane(speed, loadCapacity);
                case 5:
                    return new Tanker(speed, loadCapacity);
                case 6:
                    return new Liner(speed, loadCapacity);
            }
            return null;
        }
    }
}
