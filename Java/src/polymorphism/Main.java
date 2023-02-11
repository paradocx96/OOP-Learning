package polymorphism;

public class Main {
    public static void main(String[] args) {

        Vampire vampire = new Vampire();
        Werewolf werewolf = new Werewolf();

        Enemy[] enemy = {vampire, werewolf};

        enemy[0].Talk();
        enemy[1].Talk();
    }
}
