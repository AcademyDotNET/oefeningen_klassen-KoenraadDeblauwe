using System;

namespace Meetlat
{
    class Program
    {
        static void Main(string[] args)
        {
            Meetlat mijnLat = new Meetlat();
            mijnLat.Lengte = 2;
            Console.WriteLine($"{mijnLat.LengteInMeter} meter is {mijnLat.LengteInVoet} voet.");
            Console.WriteLine($"{mijnLat.LengteInMeter} meter is {mijnLat.LengteInKm} Km.");
            Console.WriteLine($"{mijnLat.LengteInMeter} meter is {mijnLat.LengteInCm} cm.");
        }
    }
}
