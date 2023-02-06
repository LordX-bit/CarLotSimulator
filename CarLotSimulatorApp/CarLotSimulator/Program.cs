using Microsoft.VisualBasic;
using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //Call each of the methods for each car
            {
                CarLot carLot = new CarLot();
                Car car1 = new Car();
                car1.Make = "Ford";
                car1.Model = "Focus";
                car1.Year = 2013;
                car1.EngineNoise = "vroom";
                car1.HonkNoise = "beep";
                car1.IsDrivable = true;

                carLot.ParkingLot.Add(car1);
                Console.WriteLine($"numbers of Cars in the lot is: {CarLot.numberOfCars}");
                Console.WriteLine();
                Console.ReadLine();
            };
            var car2 = new Car()



            { 
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = true,

                


            };
            

            CarLot carlot2 = new CarLot();
            Console.WriteLine($"numbers of Cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.ReadLine();




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            // Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            // foreach (
            {
                // Console.WriteLine($"year: {car.Year} Make {car.Make} Model: {car.Model}");



            }
        }
    }
}
