using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase1._2Arv
{
    internal class Weapon
    {
        public string WeaponName { get; set; }
        public int Damage { get; set; }
        

        public Weapon(string weaponName, int damage)
        {
            WeaponName = weaponName;
            Damage = damage;
        }
    }
}
