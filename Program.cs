using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Motosycle Yamaha = new Motosycle("Yamaha", "Green", "R-1", "400 km/h");
            Yamaha.name("Yamaha");
            Yamaha.color("Green");
            Yamaha.model("R-1");
            Yamaha.speed("400 km/h");
            Yamaha.move(Yamaha);
            Yamaha.stop(Yamaha);
        }
    }
}
