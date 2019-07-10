using System;

namespace new_exercise
{
    class Plane
    {
        public int NumberOfSeats { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        //method -----void means you return nothing
        public void Fly()
        {
            Console.WriteLine($"The {Make} {Model} has {NumberOfSeats} seats.");
        }

    }
}