using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var fxs = new Zero();

            // Reference the inherited property
            fxs.MainColor = "Black";
            fxs.MaximumOccupancy = 2;
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            var modelS = new Tesla();

            modelS.MainColor = "Midnight Silver";
            modelS.MaximumOccupancy = 6;
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            var mx410 = new Cessna();

            mx410.MainColor = "Silver";
            mx410.MaximumOccupancy = 14;
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            var ram = new Ram();

            ram.MainColor = "Maroon";
            ram.MaximumOccupancy = 9;
            ram.Drive();
            ram.Turn("right");
            ram.Stop();
        }
    }
}