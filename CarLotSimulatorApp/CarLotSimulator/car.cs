using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year,
            string make,
            string model,
            string honkNoise,
            string engineNoise,
            bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            IsDrivable = isDrivable;
        }

           


        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDrivable { get; set; }
        public string HonkNoise { get; set; }

        
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }
}
