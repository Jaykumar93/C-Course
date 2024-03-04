using System;

public class Game
{
    public void Battle(Character c1, Character c2)
    {
        Console.WriteLine($">>>>>>>>>>Let the battle Begin<<<<<<<<<< \n\n || {c1.name} VS {c2.name} || ");

        //Battle Condition
        
        while (c1.health > 0 && c2.health > 0)
        {

            c1.Attack(c2);
            if (c2.health > 0)
            {
                c2.Attack(c1);
            }
        }


        // wining condition
        if (c1.health <= 0)
        {
            Console.WriteLine($"{c2.name} wins!");
        }
        else
        {
            Console.WriteLine($"{c1.name} wins!");
        }
    }
}