namespace TransportCompany
{
    class Plane : AirTransport
    {
        private string className = "Plane";
        public Plane(double speed, double loadCapacity)
        {
            maxSpeed = 8100;
            maxNumberOfStaff = 15;
            maxNumberOfPassengers = 250;
            maxLoadCapacity = 150000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;     
        }
    }
}
