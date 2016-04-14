using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatlParkTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of a visit
            var visit1 = new MyVisit(); // allocates memory

            //visit1.Visit = "This Visit";
            visit1.Region = ParkRegion.PacificWest;
            visit1.ParkName = ("Yellowstone");
            Console.WriteLine("We visited: {0}",
                visit1.ParkName);
            

        }
    }
}
