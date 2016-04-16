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
            
            var visit1 = new Visit(); // creating an instance of the visit, allocates memory and a constructor method is called when keyword new is called
            visit1.TripName = "Montana Wyoming Trip Summer 2016";
            visit1.TripType = TripType.WithKids;
            //visit1.VisitNumber = 2016061234; -- number is now created with the constructor method with the new Visit keyword 
            //visit1.VisitTotalSpent = 987.234;
            visit1.Spent(300.00); ///method
            Console.WriteLine("Trip Name: {0}, Visit: {1}, Type of Trip: {2}, Total amount Spent: {3:c}",
                visit1.TripName, visit1.VisitNumber, visit1.TripType, visit1.VisitTotalSpent);

            var visit2 = new Visit(); // creating an second instance of the visit, allocates memory and a constructor method is called when keyword new is called
            visit2.TripName = "Southwest Trip Fall 2016";
            visit2.TripType = TripType.Couple;
            //visit1.VisitNumber = 2016061234; -- number is now generated with the constructor method with the new Visit keyword 
            //visit1.VisitTotalSpent = 987.234;
            visit2.Spent(16599.00);
            Console.WriteLine("Trip Name: {0}, Visit: {1}, Type of Trip: {2}, Total amount Spent: {3:c}",
                visit2.TripName, visit2.VisitNumber, visit2.TripType, visit2.VisitTotalSpent);






        }
            

    }
}



