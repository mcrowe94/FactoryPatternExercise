using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        
        public void Drive()
        {
            Console.WriteLine("You picked the Motorcycle! The Motorcycle is revving its loud engine!");
            Console.WriteLine("Vroooom!!");
        }
    }
}
