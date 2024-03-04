using System;

public class Program
{
    public static void Main()
    {
        Warrior Greninja = new Warrior("Greninja", 100, 20, 10);
        Mage Alakazam = new Mage("Alakazam", 80, 15, 5);
        Dragon Dragonite = new Dragon("Dragonite", 200, 30, 20);
       
        Game game = new Game();
        game.Battle(Greninja, Alakazam);
        

        Console.ReadKey();
    }
    
}