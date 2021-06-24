import banking.*;
import helpers.*;

public class Main {

    public static void main(String[] args) {
        task0();
    }

    private static void task0() {
        Helpers.spacer();

        var person = new Person("Fritz", "Anuth");
        var deposit = new Deposit(person, "DE12398413985986");
        var savings = new Savings(person, "DE12398413985987");

        deposit.deposit(1000.0);
        deposit.currentBalance();
        deposit.withdraw(1200.0);
        deposit.currentBalance();
        deposit.settleInterest();
        deposit.currentBalance();

        savings.currentBalance();
        savings.setAvailability(true);
        savings.currentBalance();
        savings.deposit(5000.0);
        savings.currentBalance();

        Helpers.spacer();
    }
}
