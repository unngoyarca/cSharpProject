using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase1._2Arv
{
    internal class Enemy : GameCharacter
    {
        public Enemy(string name, int hp, int healing, Weapon weapon) : base(name, hp, healing, weapon)
        {
        }
    }
}
