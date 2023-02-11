namespace CSharp.encapsulation;

class Enemy
{
    private string name;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public void Talk()
    {
        Console.WriteLine("I am your enemy");
    }
}

// public class EncapsulationMain
// {
//     public static void Main(string[] args)
//     {
//         Enemy enemy = new Enemy();
//
//         enemy.Name = "Vampire";
//         
//         Console.WriteLine(enemy.Name);
//     }
// }