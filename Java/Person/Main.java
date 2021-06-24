import java.util.ArrayList;

import types.*;

public class Main {

    public static void main(String[] args) {
        task0();
        System.out.println("");
        task1();

        System.out.println("Instances of Person: " + Person.getInstanceCount());
    }

    private static void task0() {
        spacer();

        var p = new Person ("Mustervorname", "MusterNachname");
        p.druckeDaten();
        System.out.println("");
        spacer();

        var ma = new Employee(1555, "Alex", "SirBraun");
        ma.druckeDaten();
        spacer();

        var k = new Customer (21, "Chris", "Adolphy");
        k.druckeDaten();
        spacer();
    }

    private static void task1() {
        var arr = new ArrayList<Person>();

        arr.add(new Employee(20000.0, "Willy", "Brandt"));
        arr.add(new Employee(25000.0, "Helmut", "Kohl"));
        arr.add(new Employee(30000.0, "Angela", "Merkel"));
        arr.add(new Customer(1234, "Helmut", "Schmidt"));
        arr.add(new Customer(1235, "Otto", "Bismarck"));
        arr.add(new Employee("Mein", "Name"));

        spacer();
        for (Person p : arr) {
            p.druckeDaten();
        }
        spacer();
    }

    private static void spacer() {
        System.out.println("-----------------------------");
    }
}
