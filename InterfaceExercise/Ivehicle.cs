using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface Ivehicle
    {
        public int WheelNum { get; set; }
        public int DoorNum { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        
    }
}
