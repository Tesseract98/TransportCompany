using System;
using System.Collections.Generic;

namespace TransportCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int n = 1;
            while (flag)
            {
                Console.WriteLine("Enter amount of vehicles");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new System.Exception("Negative digit");
                    }
                    flag = false;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Wrong value");
                }
            }         
            //List<AllVehicles> allVehicles = new List<AllVehicles>();         
            AllVehicles[] allVehicles = new AllVehicles[n];
            for (int i = 0; i < n; i++)
            {
                ConsoleShow();                       
                try
                {
                    int temp = int.Parse(Console.ReadLine());
                    int speed = 0;
                    int capacity = 0;
                    ConsoleElect(ref speed, ref capacity);
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