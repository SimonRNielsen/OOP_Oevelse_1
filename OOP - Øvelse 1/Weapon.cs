using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Øvelser
{
    internal class Weapon
    {
        private int damage;
        /// <summary>
        /// 
        /// </summary>
        public Weapon(string weapon)
        {
            switch (weapon)
            {
                case "knife":
                    Knife();
                    break;
                case "pistol":
                    Pistol();
                    break;
                case "rifle":
                    Rifle();
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void Pistol()
        {
            damage = 10;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Knife()
        {
            damage = 30;
        }
        /// <summary>
        /// 
        /// </summary>
        private void Rifle()
        {
            damage = 20;
        }
    }
}

