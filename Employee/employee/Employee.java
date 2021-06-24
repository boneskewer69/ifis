package employee;

import java.util.concurrent.ThreadLocalRandom;

public class Employee {
    private Name name;
    private Position position;
    private final int id;
    private int wage;

    // Constructor
    public Employee(Name p_name, Position p_position, int p_wage) {
        this.name = p_name;
        this.position = p_position;
        this.wage = p_wage;

        this.id = ThreadLocalRandom.current().nextInt(0, 1000) + 100000;
    }

    // Methods
    public String exportEmployeeData() {
        return "Name: " + this.name.lastName + ", " + this.name.firstName + "\nPosition: " + this.position + "\nID: " + this.id + "\nWage: " + this.wage + " €";
    }

    // Getter
    public Name getName() {
        return this.name;
    }
    public Position getPosition() {
        return this.position;
    }
    public int getId() {
        return this.id;
    }
    public int getWage() {
        return this.wage;
    }

    // Setter
    public void setName(Name p_name) {
        this.name = p_name;
    }
    public void setPosition(Position p_position) {
        this.position = p_position;
    }
    public void setWage(int p_wage) {
        this.wage = p_wage;
    }
}
