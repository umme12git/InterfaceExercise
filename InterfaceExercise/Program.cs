using System;
using System.Collections;
using System.Collections.Generic;


namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car();
            car.CarLiscenseNum = "239 GDK";
            car.CarSize = "Medum Small";
            car.Color = "Red";
            car.DoorNum = 4;
            car.WheelNum = 4;
            car.ModelName = "Toyota Cambry";
            car.MarketShareValue = 180.92;
            car.Make = "Toyota";

            var truck = new Truck();
            truck.CarLiscenseNum = "108 SLK";
            truck.CarSize = "Big";
            truck.Color = "White";
            truck.DoorNum = 4;
            truck.WheelNum = 4;
            truck.ModelName = "Cevrolet silverado";
            truck.MarketShareValue = 56.40;
            truck.Make = "Chevrolet";

            SUV suv = new SUV();
            suv.CarLiscenseNum = "580 RGH";
            suv.CarSize = "Medium";
            suv.Color = "Green";
            suv.DoorNum = 4;
            suv.WheelNum = 4;
            suv.ModelName = "Honda HR-V";
            suv.MarketShareValue = 33.29;
            suv.Make = "Honda";



            var vehicles = new List<Ivehicle>();
            vehicles.Add(car);
            vehicles.Add(suv);
            vehicles.Add(truck);
            var objcast1 = (vehicles[0] as Car);
            var objcast2 = (vehicles[1] as SUV);
            var objcast3 = (vehicles[2] as Truck);

                 
            
            int i = 0;
            foreach (var things in vehicles)
            {
                Console.WriteLine("*******");
                Console.WriteLine($"{things.ModelName} -- has {things.WheelNum} wheels  {things.DoorNum} doors  {things.Color} color");
                
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Other properties of the vehicles");
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("***Car***");
            Console.WriteLine($"{objcast1.Make}  {objcast1.CarLiscenseNum} with size {objcast1.CarSize} has market share value {objcast1.MarketShareValue}");
            Console.WriteLine();
            Console.WriteLine("***SUV***");
            Console.WriteLine($"{objcast2.Make}  {objcast2.CarLiscenseNum} with size {objcast2.CarSize} has market share value {objcast2.MarketShareValue}");
            Console.WriteLine();
            Console.WriteLine("***Truck***");
            Console.WriteLine($"{objcast3.Make}  {objcast3.CarLiscenseNum} with size {objcast3.CarSize} has market share value {objcast3.MarketShareValue}");


        }
    }
}
