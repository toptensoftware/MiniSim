using MiniSim.Core;
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new DriveSignal();
            var B = new DriveSignal();
            var Cin = new DriveSignal();

            var xor1 = new XorGate()
            {
                A = A,
                B = B,
            };

            var xor2 = new XorGate()
            {
                A = xor1.Y,
                B = Cin,
            };

            var and1 = new AndGate()
            {
                A = Cin,
                B = xor1.Y,
            };

            var and2 = new AndGate()
            {
                A = A,
                B = B,
            };

            var or1 = new OrGate()
            {
                A = and1.Y,
                B = and2.Y,
            };

            var S = xor2.Y;
            var Cout = or1.Y;

            A.Drive('0');
            B.Drive('0');
            Cin.Drive('0');
            Console.WriteLine($"S: {S} Cout: {Cout}");

            A.Drive('1');
            B.Drive('1');
            Cin.Drive('1');
            Console.WriteLine($"S: {S} Cout: {Cout}");

            A.Drive('1');
            B.Drive('0');
            Cin.Drive('1');
            Console.WriteLine($"S: {S} Cout: {Cout}");

        }
    }
}
