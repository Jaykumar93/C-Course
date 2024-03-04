using System;

public class Warrior : Character
{
    //Constructor for the child class
    public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void Charge(Character target)
    {
        int damage = (attack * 2) - target.defense;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"\n => {target.name} took {damage} damage from {name} due to CHARGE");
        }
        else
        {
            Console.WriteLine($"\n => {name}'s charge has no effect on {target.name}.\n");
        }
    }

        public override void Defend()
    {
        defense += 5;
        Console.WriteLine($"\n{name} defended and gains 5 defense because of special Warrior Skill.");
    }
}