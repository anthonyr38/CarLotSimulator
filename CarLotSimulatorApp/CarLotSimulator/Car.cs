using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            
        }
        public Car(int year, string make, string model, string engNoise, string hnkNoise, bool isDriveable = false)
        {

            Year = year;
            Make = make;
            Model = model;
            EngNoise = engNoise;
            HnkNoise = hnkNoise;
            Driveable = isDriveable;
        }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngNoise { get; set; }
        public string HnkNoise { get; set; }
        public bool Driveable { get; set; }

       

        public void MakeEngineNoise(string engNoise)
        {
            Console.WriteLine($"{Make} {Model} makes an engine noise like {engNoise}");
        }
        
        public void MakeHonkNoise(string hnkNoise)
        {
            Console.WriteLine($"{Make} {Model} makes a honking noise like {hnkNoise}");
        }
        
    }
}
