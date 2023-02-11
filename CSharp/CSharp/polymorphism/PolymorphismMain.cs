namespace CSharp.polymorphism;

class Enemy
{
    private string name;

    public virtual void Talk()
    {
        Console.WriteLine("I am your enemy.");
    }
}

class Vampire : Enemy
{
    public override void Talk()
    {
        Console.WriteLine("I want to suck your blood.");
    }
}

class Werewolf : Enemy
{
    public override void Talk()
    {
        Console.WriteLine("I want to bite you.");
    }
}

// public class PolymorphismMain
// {
//     public static void Main(string[] args)
//     {
//         // 1st way
//         Vampire vampire1 = new Vampire();
//         Werewolf werewolf1 = new Werewolf();
//         Enemy[] enemies = { vampire1, werewolf1 };
//         enemies[0].Talk();
//         enemies[1].Talk();
//
//         // 2nd way
//         Enemy enemy = new Enemy();
//         Enemy vampire = new Vampire();
//         Enemy werewolf = new Werewolf();
//         enemy.Talk();
//         vampire.Talk();
//         werewolf.Talk();
//     }
// }