using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface Ivehicle
    {
        int WheelNum { get; set; }
        int DoorNum { get; set; }
        string ModelName { get; set; }
        string Color { get; set; }
        
    }
}
