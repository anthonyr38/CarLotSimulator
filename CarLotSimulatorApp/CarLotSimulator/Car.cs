using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }

        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngNoise { get; set; }
        public string HnkNoise { get; set; }
        public bool Driveable { get; set; }


        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EngNoise = engineNoise;
            HnkNoise = honkNoise;
            Driveable = isDriveable;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngNoise);
        }
        
        public void MakeHonkNoise()
        {
            Console.WriteLine(HnkNoise);
        }
        
    }
}
