using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : Ivehicle, Icompany
    {
        public int WheelNum { get; set; }
        public int DoorNum { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public double MarketShareValue { get; set; }
        public string Make { get; set; } = "Honda";

        public string CarSize { get; set; }
        public string CarLiscenseNum { get; set; }
    }
}
