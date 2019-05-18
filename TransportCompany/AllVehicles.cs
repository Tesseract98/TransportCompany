using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany
{
    interface AllVehicles
    {
        void GetInformation();
        double CheckCapacity { set; get; }
        double Speed { set; get; }
        double LoadCapacity { set; get; }
        string Brand { set; get; }
        int NumberOfStaff { set; get; }
        int NumberOfPassengers { set; get; }
    }
}