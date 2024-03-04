using System;

public class Dragon : Character
{
    //Constructor for the child class
    public Dragon(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }


    public void BreatheFire(Character target)
    {
        int damage = attack * 4 - target.defense;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($" {target.name} get attacked with breathing fire by {name} and takes {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{name}'s fire has no effect on {target.name}.");
        }
    }
    public override void Defend()
    {
        Console.WriteLine($"\n{name} defended and gains 10 defense because of special Dragon Skill.");
        defense += 10;
    }
}