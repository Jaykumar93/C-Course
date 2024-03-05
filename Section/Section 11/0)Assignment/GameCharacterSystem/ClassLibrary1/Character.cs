using System;

public class Character
{
    public string name;
    public int health;
    public int attack;
    public int defense;
    
    public Character(string name, int health, int attack,int defense)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
    }

    public virtual void Attack(Character target)
    {
        int damage = this.attack - target.defense;

        if (damage > 0)
        {
            target.health -= damage;
            Console.WriteLine($"\n => {target.name} took {damage} damage from {name}");
        }
        else
        {
            Console.WriteLine($"\n => {target.name} had no damage from {name}");
        }
    }
    public virtual void Defend()
    {
        
    }
}