using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TurnBase1._2Arv
{
    internal class CreatePlayer
    {
        public static Player CreatingHero()
        {
            Random random = new Random();


            var Weapons = new List<Weapon>()
            {
                new Weapon("Short sword", 10),
                new Weapon("Spear", 11),
                new Weapon("Shotgun", 20)
            };

            var startingWeapon = Weapons.ElementAt(random.Next(Weapons.Count));

            // Starting Message:
            Console.WriteLine("Enter name:");


            // Defines the hero character's name, stats and applies the randomized starting weapon:
            var hero = new Player(Console.ReadLine(), 50, 10, startingWeapon);

            Console.WriteLine("Welcome!");
            Console.WriteLine("Name " + hero.Name + " Weapon name: " + hero.Weapon.WeaponName + " Weapon Damage: " + hero.Weapon.Damage);

            return hero;

        }

        public static void HeroAttack(GameCharacter hero, Random random, Enemy enemy)
        {

            int randomAttack = random.Next(hero.Weapon.Damage + 5);

            hero.Hp -= enemy.Weapon.Damage;
            Console.WriteLine($"{hero.Name} attacked {enemy.Name} & lost {randomAttack} health and has {enemy.Hp} remaining");
        }

        public static void Heal(GameCharacter hero)
        {
            hero.Hp += hero.Healing;
            Console.WriteLine($"{hero.Name} has heal {hero.Healing}");
        }

    }
}
    
