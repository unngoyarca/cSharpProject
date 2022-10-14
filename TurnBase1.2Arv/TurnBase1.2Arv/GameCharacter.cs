using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBase1._2Arv
{
                    // Game Character can be any character in the game/program.
    internal class GameCharacter
    {
            public string Name { get; set; }
            public int Hp { get; set; }
            public int Healing { get; set; }
            
            public Weapon Weapon { get; set; }
            private readonly Random _rnd = new Random();

            public GameCharacter(string name, int hp, int healing, Weapon weapon)
            {
                Name = name;
                Hp = hp;
                Healing = healing;
                Weapon = weapon;
            

              
            }
       

    }
}
       