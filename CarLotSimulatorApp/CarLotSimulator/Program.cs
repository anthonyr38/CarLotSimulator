using CarLotSimulator;
using System;
using System.Collections.Generic;
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

var autoLot = new CarLot();


var carA = new Car();


carA.Year = 2022;
carA.Make = "Mitsubishi";
carA.Model = "Outlander";
carA.EngNoise = "Vroom";
carA.HnkNoise = "Beep Beep";
carA.Driveable = true;

Console.WriteLine($"We now have {CarLot._amtOfCars} automobiles in our motorpool");

autoLot.Autos.Add(carA);



//carA.MakeEngineNoise();
//carA.MakeHonkNoise();

var carB = new Car()
{
    Year = 2019,
    Make = "Chevrolet",
    Model = "Cruze",
    EngNoise = "Vroom Vroom",
    HnkNoise = "Beepy Beep",
    Driveable = true
};


Console.WriteLine($"We now have {CarLot._amtOfCars} automobiles in our motorpool");

autoLot.Autos.Add(carB);



var carC = new Car(2018, "Nissan", "Versa", "Zoomy Zoom", "Beepity Beepy", false);

Console.WriteLine($"We now have {CarLot._amtOfCars} automobiles in our motorpool");

autoLot.Autos.Add(carC);



Console.WriteLine("------------------");

//*************BONUS X 2*************//

//Console.WriteLine($" We have a total of {CarLot.numberOfCars} cars");

autoLot.CarCheck();
