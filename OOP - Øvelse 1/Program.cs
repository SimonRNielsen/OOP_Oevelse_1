using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Øvelser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier firstSoldier = new Soldier("Svend", 100, 20);
            Soldier secondSoldier = new Soldier("Børge", 100, 30, 20, 20);
            Console.WriteLine(firstSoldier.GetName() + "\nHealth " + firstSoldier.GetHealth() + "\nArmor " + firstSoldier.GetArmor());
            Console.WriteLine();
            Console.WriteLine(secondSoldier.GetName() + "\nHealth " + secondSoldier.GetHealth() + "\nSpeed " + secondSoldier.GetSpeed() + "\nEnergy " + secondSoldier.GetEnergy() + "\nArmor " + secondSoldier.GetArmor());
            /*
            firstSoldier.Move();
            firstSoldier.Shoot();
            firstSoldier.Jump();
            */
            /*
            firstSoldier.SetHealth(85);
            Console.WriteLine(firstSoldier.GetHealth());
            */
            Console.ReadKey();
        }
    }
}
