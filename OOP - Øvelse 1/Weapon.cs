using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Øvelser
{
    internal class Weapon
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Damage {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Range {  get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Weapon(string type)
        {
            switch (type)
            {
                case "knife":
                    Type = "Knife";
                    Damage = 30;
                    Range = 1;
                    break;
                case "pistol":
                    Type = "Pistol";
                    Damage = 10;
                    Range = 3;
                    break;
                case "rifle":
                    Type = "Rifle";
                    Damage= 20;
                    Range = 5;
                    break;
            }
        }
        public int GetDamage(int damage)
        {
            return Damage;
        }
    }
}

