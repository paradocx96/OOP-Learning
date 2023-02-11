package encapsulation;

public class Enemy {

    private int health;

    public void Talk() {
        System.out.println("I am your enemy.");
    }

    public void setHealth(int health) {
        this.health = health;
    }

    public int getHealth() {
        return this.health;
    }
}
