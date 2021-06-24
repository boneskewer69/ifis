package banking;

public class Person {
    private String firstName;
    private String lastName;

    public Person(String p_firstName, String p_lastName) {
        this.firstName = p_firstName;
        this.lastName = p_lastName;
    }

    public String getFirstName() {
        return this.firstName;
    }
    public String getLastName() {
        return this.lastName;
    }
}
