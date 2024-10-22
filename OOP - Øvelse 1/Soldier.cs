using OOP___Øvelse_1;
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
        private int[] location = new int[2];
        public bool InCar = false;
        private Jeep jeep = new Jeep(0);
        /// <summary>
        /// Get/set property for health integer
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
        /// Get/set property for armor integer
        /// </summary>
        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value > 100)
                {
                    this.armor = 100;
                }
                else
                {
                    this.armor = value;
                }
            }
        }
        /// <summary>
        /// Get/set property for energy integer
        /// </summary>
        public int Energy { get => energy; set => energy = value; }
        /// <summary>
        /// Get/set property for speed float
        /// </summary>
        public float MoveSpeed { get => speed; set => speed = value; }
        /// <summary>
        /// Get property for name string (readonly)
        /// </summary>
        public string Name { get => name; }
        /// <summary>
        /// 
        /// </summary>
        internal Weapon[] Weapon { get => weapon; set => weapon = value; }
        /// <summary>
        /// Basic constructor for object "Soldier"
        /// </summary>
        /// <param name="name">name of soldier in string</param>
        /// <param name="health">amount of health between 1-100</param>
        /// <param name="speed">movement speed in a float value</param>
        /// <param name="energy">amount of energy the soldier has</param>
        /// <param name="armor">amount of armor soldier has (max. 100)</param>
        /// <param name="selectWeapon">equips the soldier with indicated weapon</param>
        public Soldier(string name, int health, int armor, int energy, float speed, string selectWeapon)
        {
            this.name = name;
            this.Health = health;
            this.MoveSpeed = speed;
            this.Energy = energy;
            this.Armor = armor;
            Weapon[0] = new Weapon(selectWeapon);
        }
        /// <summary>
        /// Advanced constructor for object "Soldier"
        /// </summary>
        /// <param name="name">name of soldier in string</param>
        /// <param name="health">amount of health between 1-100</param>
        /// <param name="speed">movement speed in a float value</param>
        /// <param name="energy">amount of energy the soldier has</param>
        /// <param name="armor">amount of armor soldier has (max. 100)</param>
        /// <param name="selectWeapon1">equips the soldier with indicated weapon</param>
        /// <param name="selectWeapon2">equips the soldier with indicated weapon</param>
        public Soldier(string name, int health, int armor, int energy, float speed, string selectWeapon1, string selectWeapon2)
        {
            this.name = name;
            this.Health = health;
            this.MoveSpeed = speed;
            this.Energy = energy;
            this.Armor = armor;
            Weapon[0] = new Weapon(selectWeapon1);
            Weapon[1] = new Weapon(selectWeapon2);
        }
        /// <summary>
        /// Complete constructor for object "Soldier"
        /// </summary>
        /// <param name="name">name of soldier in string</param>
        /// <param name="health">amount of health between 1-100</param>
        /// <param name="speed">movement speed in a float value</param>
        /// <param name="energy">amount of energy the soldier has</param>
        /// <param name="armor">amount of armor soldier has (max. 100)</param>
        /// <param name="selectWeapon1">equips the soldier with indicated weapon</param>
        /// <param name="selectWeapon2">equips the soldier with indicated weapon</param>
        /// <param name="selectWeapon3">equips the soldier with indicated weapon</param>
        public Soldier(string name, int health, int armor, int energy, float speed, string selectWeapon1, string selectWeapon2, string selectWeapon3)
        {
            this.name = name;
            this.Health = health;
            this.MoveSpeed = speed;
            this.Energy = energy;
            this.Armor = armor;
            Weapon[0] = new Weapon(selectWeapon1);
            Weapon[1] = new Weapon(selectWeapon2);
            Weapon[2] = new Weapon(selectWeapon3);
        }
        /// <summary>
        /// Function to change location on y-axis (left-right)
        /// </summary>
        public void Move()
        {
            Console.WriteLine("I'm moving");
            location[1] += (int)this.MoveSpeed;
            Console.Write("New location: ");
            foreach (int i in location)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Function to change location on x-axis (top to bottom)
        /// </summary>
        public void Jump()
        {
            Console.WriteLine("JUMP!");
            location[0]++;
            Console.Write("New location: ");
            foreach (int i in location)
            {
                Console.WriteLine($"New location: {location[0]}, {location[1]}");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Fuction to make the soldier shoot (does nothing at the moment)
        /// </summary>
        public void Shoot()
        {
            Console.WriteLine("BANG!");
        }
        /// <summary>
        /// "Prints" the weaponinfo to console
        /// </summary>
        /// <param name="slot">Weapon slot that you want info from</param>
        public void WeaponInfo(int slot)
        {
            Console.WriteLine(this.name + " is using a " + this.Weapon[slot].Type + " which has a range of " + this.Weapon[slot].Range + " and does " + this.Weapon[slot].Damage + " damage");
        }
        /// <summary>
        /// Soldier gets into a car
        /// </summary>
        public void GetCar()
        {
            jeep = new Jeep(2);
            InCar = true;
            Console.WriteLine(this.Name + " now has a Jeep");
            Console.WriteLine("It has fuel for " + this.jeep.Fuel + " moves");
        }
        /// <summary>
        /// Function to make the soldier drive a car
        /// </summary>
        /// <param name="inCar">Must be "true" to activate</param>
        public void Drive()
        {
            if (InCar && this.jeep.Fuel > 0) 
            {
                this.location[1] += ((int)this.MoveSpeed)*3;
                Console.WriteLine($"New location: {location[0]}, {location[1]}");
                this.jeep.Fuel--;
                Console.WriteLine("You have fuel for " + this.jeep.Fuel + " moves remaining");
            }
            else
            {
                InCar = false;
                Console.WriteLine("Not in a car");
            }
        }
        /// <summary>
        /// Method to get the health value of the soldier
        /// </summary>
        /// <returns>Health value</returns>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// Method to change the health value of the soldier
        /// </summary>
        /// <param name="value">between 0-100</param>
        public void SetHealth(int value)
        {
            this.Health = value;
        }
        /// <summary>
        /// Method to get the soldiers armor value
        /// </summary>
        /// <returns>Armor value</returns>
        public int GetArmor()
        {
            return armor;
        }
        /// <summary>
        /// Method to set the soldiers armor value
        /// </summary>
        /// <param name="value">maximum of 100</param>
        public void SetArmor(int value)
        {
            this.Armor = value;
        }
        /// <summary>
        /// Method to read the soldiers speed
        /// </summary>
        /// <returns>Movement speed</returns>
        public float GetSpeed()
        {
            return speed;
        }
        /// <summary>
        /// Method to set the speed of the soldier
        /// </summary>
        /// <param name="value">Movement speed</param>
        public void SetSpeed(float value)
        {
            this.MoveSpeed = value;
        }
        /// <summary>
        /// Method to read the soldiers energylevel
        /// </summary>
        /// <returns>Energylevel</returns>
        public int GetEnergy()
        {
            return energy;
        }
        /// <summary>
        /// Method to set the soldiers energylevel
        /// </summary>
        /// <param name="value">Desired energylevel</param>
        public void SetEnergy(int value)
        {
            this.Energy = value;
        }
        /// <summary>
        /// Method to read the soldiers name
        /// </summary>
        /// <returns>Name</returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Boolean to check if the soldier is alive
        /// </summary>
        /// <returns>true|false</returns>
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
    }
}
