using System;
using System.Collections.Generic;


namespace TransportCompany
{
    class NameOfVehicle
    {
        private Dictionary<int, String> names;

        public NameOfVehicle()
        {
            names = new Dictionary<int, string>
            {
                [1] = "Car",
                [2] = "Train",
                [3] = "Helicopter",
                [4] = "Plane",
                [5] = "Tanker",
                [6] = "Liner",
            };
        }

        public Dictionary<int, String> NamesDictionary
        {
            get
            {
                return names;
            }
        }

    }
}
