using System;
using System.Collections.Generic;

namespace new_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cessna = new Plane()
            {
                NumberOfSeats = 7,
                Model = "Model AA",
                Make = "Cessna",
            };

            var flyer = new Plane()
            {
                NumberOfSeats = 1,
                Model = "Wright Flyer",
                Make = "Wright Cycle Company",
            };

            var hanger = new List<Plane>() { cessna, flyer };


            foreach (Plane airplane in hanger)
            {
                airplane.Fly();
            }
        }
    }
}
