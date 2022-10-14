using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase1._2Arv
{
    internal class EnemyCreate
    {
        public static Enemy CreatingEnemy()
        {
            Random random = new Random();

            var Weapons = new List<Weapon>()
            {
                new Weapon("Short sword", 10),
                new Weapon("Spear", 11),
                new Weapon("Shotgun", 20)
            };
            var startingWeapon = Weapons.ElementAt(random.Next(Weapons.Count));

            var enemy = new Enemy(Console.ReadLine(), 50, 10, startingWeapon);

            Console.WriteLine("Enemy have " + enemy.Weapon.WeaponName + "with "+ enemy.Weapon.Damage);

            return enemy;
        }

        public void EnemyAttack(GameCharacter hero, Random weapons, Enemy enemy)
        {

            int randomAttack = random.Next(enemy.Weapon.Damage + 5);

            enemy.Hp -= hero.Weapon.Damage;
            Console.WriteLine($"{enemy.Name} attacked {hero.Name} & lost {randomAttack} health and has {hero.Hp} remaining");
        }

        public void EnemyHeal(GameCharacter enemy)
        {
            enemy.Hp += enemy.Healing;
            Console.WriteLine($"{enemy.Name} has heal {enemy.Healing}");
        }


    }
}
