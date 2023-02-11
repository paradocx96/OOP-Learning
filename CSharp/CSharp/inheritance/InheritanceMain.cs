namespace CSharp.inheritance;

class Enemy
{
    private string name;

    public void Talk()
    {
        Console.WriteLine("I am your enemy.");
    }
}

class Vampire : Enemy
{
}

// public class InheritanceMain
// {
//     public static void Main(string[] args)
//     {
//         Vampire vampire = new Vampire();
//         
//         vampire.Talk();
//     }
// }