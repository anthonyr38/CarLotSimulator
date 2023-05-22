using System;
using System.Collections.Generic;

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





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            CarLot autoLot = new CarLot();


            Car carA = new Car();
            
            autoLot.CarsList.Add(carA);
            
            carA.Year = 2022;
            carA.Make = "Mitsubishi";
            carA.Model = "Outlander";
            carA.EngNoise = "Vroom";
            carA.HnkNoise = "Beep Beep";
            carA.Driveable = true;


            carA.MakeEngineNoise();
            carA.MakeHonkNoise();

            Car carB = new Car() { Year = 2019, Make = "Chevrolet", Model = "Cruze", EngNoise = "Vroom Vroom", HnkNoise = "Beepy Beep", Driveable = true };
            autoLot.CarsList.Add(carB);

            carB.MakeEngineNoise();
            carB.MakeHonkNoise();

            Car carC = new Car(2018, "Nissan", "Versa", "Zoomy Zoom", "Beepity Beepy");

            autoLot.CarsList.Add(carC);

            carC.MakeEngineNoise();
            carC.MakeHonkNoise();

            Console.WriteLine("------------------");

            //*************BONUS X 2*************//
            foreach (var auto in autoLot.CarsList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {auto.Year} Make: {auto.Make} Model: {auto.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
