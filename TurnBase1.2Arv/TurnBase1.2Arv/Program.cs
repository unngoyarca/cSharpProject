namespace TurnBase1._2Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var hero = CreatePlayer.CreatingHero();

            var enemy = EnemyCreate.CreatingEnemy();
            
            Console.WriteLine("Hero's name is now: " + hero.Name);

            while (hero.Hp > 0 && enemy.Hp > 0)
            {
                Console.WriteLine("Enter 'a' to Attack or 'h' to heal!");
                string choice = Console.ReadLine();

                if (choice == "a") CreatePlayer.HeroAttack(EnemyCreate.EnemyHeal);
                else CreatePlayer.Heal();

                int enemyChoice = random.Next(0, 1);
                if (enemyChoice == 0) EnemyCreate.Attack(hero);
                else EnemyCreate.Heal();

            }
            //Random random = new Random();
            //var GameCharacter = new GameCharacter("Adrian", 50, 10, 8);
            //var Enemy = new GameCharacter("Bjørnar", 40, 15, 5);

            //while (GameCharacter.Hp > 0 && Enemy.Hp > 0)
            //{
            //    Console.WriteLine("Enter 'a' to attack or 'h' to heal");

            //    string choice = Console.ReadLine();
            //    if (choice == "a") GameCharacter.Attack(Enemy);
            //    else GameCharacter.Heal();

            //    int enemyChoice = random.Next(0, 2);
            //    if (enemyChoice == 0) Enemy.Heal();
            //    else Enemy.Attack(GameCharacter);
            //}

            //if (GameCharacter.Hp > 0) Console.WriteLine("You Won!");
            //else Console.WriteLine("You lost.. goddamnit!!");

        }

        
    }
}