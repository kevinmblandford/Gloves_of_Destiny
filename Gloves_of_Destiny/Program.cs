int[] encounters = {1,3,4,1,2,1,4,2};
string type = "";
Random random = new Random();
int hero_life = 100;
int score = 0;
for (int i = 0; i < encounters.Length; i++)
{
    switch (encounters[i])
    {
        case 1:
        type = "monster!";
        int monster_damage = random.Next();
        int monster_life = 10;
        Console.WriteLine($"You've come across a {type} Prepare for battle.");
            do
                {
                    monster_damage = random.Next(1, 11);
                    monster_life -= monster_damage;
                    Console.WriteLine($"Monster was damaged and lost {monster_damage} health and now has {monster_life} health");
    
                if (monster_life <= 0) continue;

                int hero_damage = random.Next(1, 101);
                hero_life -= hero_damage;
                Console.WriteLine($"Hero was damaged and lost {hero_damage} health and now has {hero_life} health");
                } while (monster_life > 0 && hero_life > 0);
                if (monster_life > hero_life)
                    {
                        Console.WriteLine($"You have been slain! Your final score was {score}. Good luck on your next run hero!");
                        goto end_death;
                    }
                    else
                        {
                            score += 100;
                            Console.WriteLine($"The Monster has been slain, congratulations! Your current score is {score}.");
                        }
        break;
        case 2:
        type = "chest!";
        int loot = random.Next(1,6);
        Console.WriteLine($"You've found a {type} Let's see what's inside.");
        switch (loot)
            {
                case 1:
                score += 30;
                Console.WriteLine($"You found some gold! Your current score is {score}");
                break;
                case 2:
                Console.WriteLine($"You found a Mimic! prepare for battle!");
                monster_life = 10;
            do
                {
                    monster_damage = random.Next(1, 11);
                    monster_life -= monster_damage;
                    Console.WriteLine($"Mimic was damaged and lost {monster_damage} health and now has {monster_life} health");
    
                if (monster_life <= 0) continue;

                int hero_damage = random.Next(1, 101);
                hero_life -= hero_damage;
                Console.WriteLine($"Hero was damaged and lost {hero_damage} health and now has {hero_life} health");
                } while (monster_life > 0 && hero_life > 0);
                if (monster_life > hero_life)
                    {
                        Console.WriteLine($"You have been slain! Your final score was {score}. Good luck on your next run hero!");
                        goto end_death;
                    }
                    else
                        {
                            score += 100;
                            Console.WriteLine($"The Mimic has been slain, congratulations! Your current score is {score}.");
                        }
                break;
                case 3:
                score += 1000000;
                Console.WriteLine($"You have found the GLOOOOOOOVES OF DESTINY. Now all you have to do is make it out alive. Your current score is {score}.");
                break;
                case 4:
                score +=10;
                hero_life +=20;
                if (hero_life > 100)
                    {
                        hero_life = 100;
                    }
                Console.WriteLine($"You found some healing powder. Your current health is {hero_life}");
                break;
                case 5:
                Console.WriteLine($"The chest was empty. Better luck next time hero.");
                break;
            }
        break;
        case 3:
        hero_life = 100;
        Console.WriteLine($"You encounter a mysterious glade. You rest, and you feel a burden removed from your shoulders. Your current health is {hero_life}");
        break;
        case 4:
        int trap = random.Next(1,4);
        type = "a trap!";
        Console.WriteLine($"You've stumbled into {type}");
        switch (trap)
        {
                case 1:
                Console.WriteLine($"You fall down an endless chasm. Your final score was {score}. Good luck on your next run hero!");
                goto end_death;
                case 2:
                Console.WriteLine($"You deftly avoid arrows from a nearby trap.");
                break;
                case 3:
                hero_life -= 20;
                Console.WriteLine($"You step on a bear trap, you lose 20 health. Your current health is {hero_life}");
                break;
        }
        break;
    }
}
end_death: Console.WriteLine($"Your journey has ended hero, but this is only one of many experiences. Shall we try another run?");