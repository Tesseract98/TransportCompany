namespace TransportCompany
{
    class Liner : WaterTransport
    {
        private string className = "Liner";
        public Liner(double speed, double loadCapacity)
        {
            maxSpeed = 59;
            maxNumberOfStaff = 100;
            maxNumberOfPassengers = 700;
            maxLoadCapacity = 120000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;
        }
    }
}
