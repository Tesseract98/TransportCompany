using System;
using System.Collections.Generic;

namespace TransportCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of vehicles");
            int n = int.Parse(Console.ReadLine());
            //List<AllVehicles> allVehicles = new List<AllVehicles>();         
            AllVehicles[] allVehicles = new AllVehicles[n];
            for (int i = 0; i < n; i++)
            {
                ConsoleShow();
                int temp = int.Parse(Console.ReadLine());
                int speed = 0;
                int capacity = 0;
                ConsoleElect(ref speed, ref capacity);
                try
                {
                    CreateVehicles create = new CreateVehicles();
                    allVehicles[i] = create.Create(temp, speed, capacity);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    i--;
                }
            }
            Console.WriteLine();
            foreach (AllVehicles all in allVehicles)
            {
                all.GetInformation();
                Console.WriteLine();
            }
            Console.Read();
        }
        static void ConsoleShow()
        {
            Console.WriteLine("Enter the number of vehicle");
            Console.WriteLine(TypeOfVehicle.Car.GetHashCode() + " " + TypeOfVehicle.Car.ToString());
            Console.WriteLine(TypeOfVehicle.Train.GetHashCode() + " " + TypeOfVehicle.Train.ToString());
            Console.WriteLine(TypeOfVehicle.Helicopter.GetHashCode() + " " + TypeOfVehicle.Helicopter.ToString());
            Console.WriteLine(TypeOfVehicle.Plane.GetHashCode() + " " + TypeOfVehicle.Plane.ToString());
            Console.WriteLine(TypeOfVehicle.Tanker.GetHashCode() + " " + TypeOfVehicle.Tanker.ToString());
            Console.WriteLine(TypeOfVehicle.Liner.GetHashCode() + " " + TypeOfVehicle.Liner.ToString());
        }
        static void ConsoleElect(ref int speed, ref int capacity)
        {
            Console.WriteLine("Enter speed");
            speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter capacity");
            capacity = int.Parse(Console.ReadLine());
        }
    }
}