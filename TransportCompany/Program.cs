using System;

namespace TransportCompany
{
    class Program
    {
        private static NameOfVehicle names = new NameOfVehicle();
        static void Main(string[] args)
        {
            AllVehicles[] allVehicles;
            var n = 1;
            Console.WriteLine("Enter amount of vehicles");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    throw new System.Exception($"Negative digit n = {n}");
                }

                allVehicles = new AllVehicles[n];
                for (int i = 0; i < n; i++)
                {
                    ConsoleShow();
                    var temp = int.Parse(Console.ReadLine());
                    var namesDictionarySize = names.NamesDictionary.Count;
                    if (temp < 0 || temp > namesDictionarySize)
                    {
                        throw new System.Exception($"Wrong number of vehicle {temp}. number in [1, {namesDictionarySize}]");
                    }
                    var speed = 0.0;
                    var capacity = 0.0;
                    ConsoleElect(ref speed, ref capacity);
                    CreateVehicles create = new CreateVehicles();
                    allVehicles[i] = create.Create(names.NamesDictionary[temp], speed, capacity);
                }
                Console.WriteLine();
                foreach (AllVehicles all in allVehicles)
                {
                    all.GetInformation();
                    Console.WriteLine();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(String.Format("{0} \n {1}", exc.Message, exc.StackTrace));
            }
            Console.Read();
        }

        static void ConsoleShow()
        {
            Console.WriteLine("Enter the number of vehicle");
            foreach(int i in names.NamesDictionary.Keys)
            {
                Console.WriteLine(String.Format("{0}) {1}", i, names.NamesDictionary[i]));
            }
        }
        static void ConsoleElect(ref double speed, ref double capacity)
        {
            Console.WriteLine("Enter speed");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter capacity");
            capacity = Convert.ToDouble(Console.ReadLine());
        }
    }
}