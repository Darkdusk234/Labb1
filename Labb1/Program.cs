using System;

namespace Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Första cirkelns area är: {circle1.GetArea()}");
            Console.WriteLine($"Första cirkelns omkrets är: {circle1.GetCircumference()}");
            Console.WriteLine($"Första klotets area är: {circle1.GetSphereArea()}");
            Console.WriteLine($"Första klotets volym är: {circle1.GetSphereVolume()}");
            Console.WriteLine($"Andra cirkelns area är: {circle2.GetArea()}");
            Console.WriteLine($"Andra cirkelns omkrets är: {circle2.GetCircumference()}");
            Console.WriteLine($"Andra klotets area är: {circle2.GetSphereArea()}");
            Console.WriteLine($"Andra klotets volym är: {circle2.GetSphereVolume()}");

            Triangel triangel1 = new Triangel(3, 5);
            Triangel triangel2 = new Triangel(7, 2);

            Console.WriteLine($"Första triangelns area är: {triangel1.GetArea()}");
            Console.WriteLine($"Första konens volym är: {triangel1.GetConeVolume()}");
            Console.WriteLine($"Andra triangelns area är: {triangel2.GetArea()}");
            Console.WriteLine($"Andra konens volym är: {triangel2.GetConeVolume()}");
        }
    }
}
