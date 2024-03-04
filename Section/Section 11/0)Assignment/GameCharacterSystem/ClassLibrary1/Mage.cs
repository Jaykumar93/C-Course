using System;

public class Mage : Character
{
    //Constructor for the child class
    public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void CastSpell(Character target)
    {
        int damage = (attack * 3) - target.defense;
        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"\n => {target.name} took {damage} damage from {name} due to CastSpell");
        }
        else
        {
            Console.WriteLine($"\n => {name}'s CastSpell has no effect on {target.name}.\n");
        }
    }
    public sealed override void Defend()
    {
        Console.WriteLine($"{name} cannot defend!");
    }
}