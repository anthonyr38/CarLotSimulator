using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int _amtOfCars = 0;

        //public int AmtOfCars {  get; set; }
        public List<Car> Autos { get; set; } = new List<Car>();

        

        public void CarCheck() 
        {
            foreach (var auto in Autos) 
            {
                Console.WriteLine($"This is a {auto.Make} {auto.Model} made in the year {auto.Year}");
                auto.MakeEngineNoise(auto.EngNoise);
                auto.MakeHonkNoise($"{auto.HnkNoise}\n");
            }    
        }

        
        
    }
}
