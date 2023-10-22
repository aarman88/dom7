using System;
using dom7;

namespace TanksBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] t34Tanks = new Tank[5];
            Tank[] panteraTanks = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tank("Т-34");
                panteraTanks[i] = new Tank("Pantera");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Бой {i + 1}:");
                Console.WriteLine(t34Tanks[i].GetTankParameters());
                Console.WriteLine(panteraTanks[i].GetTankParameters());

                if (t34Tanks[i] ^ panteraTanks[i])
                    Console.WriteLine("Победитель: Т-34");
                else
                    Console.WriteLine("Победитель: Pantera");

                Console.WriteLine();
            }
        }
    }
}
