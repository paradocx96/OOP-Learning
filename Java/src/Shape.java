public class Shape {

    protected String name;

    public Shape() {
    }

    public Shape(String name) {
        this.name = name;
    }
}

class Rectangle extends Shape {

    protected int areaValue;

    Rectangle(String name, int area) {
        super(name);
        areaValue = area;
    }

    public void print() {
        System.out.println("Shape:" + name + " Area:" + areaValue);
    }
}

class Circle extends Shape {
    protected int areaValue;

    Circle(String name, int area) {
        super(name);
        areaValue = area;
    }

    public void print() {
        System.out.println("Shape:" + name + " Area:" + areaValue);
    }
}

class ShapeApp {
    public static void main(String[] args) {
        Rectangle r1 = new Rectangle("Rectangle 1", 10);
        Circle c1 = new Circle("Circle 1", 10);
        r1.print();
        c1.print();
    }
}