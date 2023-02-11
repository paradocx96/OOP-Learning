namespace CSharp.abstraction;

class Enemy
{
    private string name;

    public void Talk()
    {
        Console.WriteLine("I am your enemy");
    }
}

// public class AbstractionMain
// {
//     public static void Main(string[] args)
//     {
//         Enemy enemy = new Enemy();
//         
//         enemy.Talk();
//     }
// }