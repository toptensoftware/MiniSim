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

            var fulladder = new FullAdder()
            {
                A = A,
                B = B,
                Cin = Cin,
            };

            var S = fulladder.S;
            var Cout = fulladder.Cout;


            var circuit = new Circuit(S, Cout);

            circuit.StartCycle();
            A.Drive('0');
            B.Drive('0');
            Cin.Drive('0');
            Console.WriteLine($"S: {S} Cout: {Cout}");

            circuit.StartCycle();
            A.Drive('1');
            B.Drive('1');
            Cin.Drive('1');
            Console.WriteLine($"S: {S} Cout: {Cout}");

            circuit.StartCycle();
            A.Drive('1');
            B.Drive('0');
            Cin.Drive('1');
            Console.WriteLine($"S: {S} Cout: {Cout}");

        }
    }
}
