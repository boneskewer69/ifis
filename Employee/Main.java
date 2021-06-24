import employee.*;

public class Main {
    public static void main(String[] args) {
        Employee max = new Employee(new Name("Max", "Driessen"), Position.SWDEV, 10);
        max.exportEmployeeData();
    }
}
