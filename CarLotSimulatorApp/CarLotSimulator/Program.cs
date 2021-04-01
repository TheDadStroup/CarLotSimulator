using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car   DONE


            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable  DONE


            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()  DONE


            //The methods should take one string parameter: the respective noise property DONE



            //Now that the Car class is created we can instanciate 3 new cars

            var lot = new CarLot();
            


            var billsCar = new Car();
            billsCar.Make = "Triumph";
            billsCar.Model = "Spitfire";
            billsCar.Year = 1972;
            billsCar.EngineNoise = "purr";
            billsCar.HonkNoise = "War Eagle";
            billsCar.IsDrivable = true;

            lot.Cars.Add(billsCar);


            var raysCar = new Car()
            {

                Year = 1982,
                Make = "Nissan",
                Model = "280Z",
                EngineNoise = "Brmmp",
                HonkNoise = "Honk!",
                IsDrivable = false
            };
            lot.Cars.Add(raysCar);
            var whitsCar = new Car(2007, "Jeep", "Wrangler", "uuuga", "vrooom", true);
            lot.Cars.Add(whitsCar);

            whitsCar.MakeEngineNoise();
            raysCar.MakeHonkNoise();
            billsCar.MakeEngineNoise();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car  in lot.Cars)
            {
                Console.WriteLine($" Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
