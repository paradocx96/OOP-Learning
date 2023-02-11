package encapsulation;

public class Main {

    public static void main(String []args){
        Enemy enemy = new Enemy();

        enemy.setHealth(99);

        System.out.println(enemy.getHealth());
    }
}
