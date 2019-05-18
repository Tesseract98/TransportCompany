namespace TransportCompany
{
    class Helicopter : AirTransport
    {
        private string className = "Helicopter";
        public Helicopter(double speed, double loadCapacity)
        {
            maxSpeed = 400;
            maxNumberOfStaff = 4;
            maxNumberOfPassengers = 30;
            maxLoadCapacity = 15000;
            name = className;
            Speed = speed;
            LoadCapacity = loadCapacity;                  
        }    
    }
}
