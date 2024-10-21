using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Øvelser
{
    internal class Soldier
    {
        private int health = 100;
        private int armor;
        private int energy;
        private float speed;
        private string name;
        private Weapon[] weapon = new Weapon[3];
        private int [] location = new int[2];
        /// <summary>
        /// 
        /// </summary>
        public int Health 
        { 
            get { return health; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    health = value;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else if (value > 100)
                {
                    health = 100;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Armor 
        {
            get 
            {
                if (armor > 100)
                {
                    return 100;
                }
                else
                {
                    return armor;
                }
            }
            set
            {
                this.armor = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Energy { get => energy; set => energy = value; }
        /// <summary>
        /// 
        /// </summary>
        public float Speed { get => speed; set => speed = value; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get => name;}
        /// <summary>
        /// 
        /// </summary>
        public void Move()
        {
            Console.WriteLine("I'm moving");
            location[1]++;
            Console.Write("New location: ");
            foreach (int i in location)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Jump()
        {
            Console.WriteLine("JUMP!");
            location[0]++;
            Console.Write("New location: ");
            foreach(int i in location)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Shoot()
        {
            Console.WriteLine("BANG!");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public void SetHealth(int value)
        {
            this.health = value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetArmor()
        {
            return armor;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float GetSpeed()
        {
            return speed;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetEnergy()
        {
            return energy;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsAlive()
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="speed"></param>
        /// <param name="energy"></param>
        /// <param name="armor"></param>
        public Soldier(string name, int health, float speed, int energy, int armor)
        {
            this.name = name;
            this.health = health;
            this.speed = speed;
            this.energy = energy;
            this.armor = armor;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="armor"></param>
        /// <param name="weapon"></param>
        public Soldier(string name, int health, int armor, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            
        }
    }
}
