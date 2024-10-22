using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Øvelser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier firstSoldier = new Soldier("Svend", 100, 30, 20, 20, "rifle");
            Soldier secondSoldier = new Soldier("Børge", 100, 30, 20, 20, "pistol", "knife");
            Console.WriteLine(firstSoldier.GetName() + "\nHealth " + firstSoldier.GetHealth() + "\nArmor " + firstSoldier.GetArmor());
            Console.WriteLine();
            firstSoldier.WeaponInfo(0);
            Console.WriteLine();
            Console.WriteLine(secondSoldier.Name + "\nHealth " + secondSoldier.Health + "\nSpeed " + secondSoldier.MoveSpeed + "\nEnergy " + secondSoldier.Energy + "\nArmor " + secondSoldier.Armor);
            secondSoldier.WeaponInfo(0);
            secondSoldier.WeaponInfo(1);
            firstSoldier.Move();
            firstSoldier.Drive();
            firstSoldier.GetCar();
            firstSoldier.Drive();
            firstSoldier.Drive();
            firstSoldier.Drive();
            Console.ReadKey();
        }
    }
}
