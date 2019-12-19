namespace TransportCompany
{
    class Tanker : WaterTransport
    {
        private string className = "Tanker";
        public Tanker(double speed, double loadCapacity)
        {
            maxSpeed = 60;
            maxNumberOfStaff = 300;
            maxNumberOfPassengers = 4000;
            maxLoadCapacity = 110000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;
        }
    }
}
