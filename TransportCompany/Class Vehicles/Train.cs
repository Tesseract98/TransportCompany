namespace TransportCompany
{
    class Train : GroundTransport
    {
        private string className = "Train";
        public Train(double speed, double loadCapacity)
        {
            maxSpeed = 580.5;
            maxNumberOfStaff = 60;
            maxNumberOfPassengers = 1100;
            maxLoadCapacity = 250000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;     
        }
    }
}