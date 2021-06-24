package banking;

import helpers.Helpers;

public class Account {
    protected Person person;
    protected String iban;
    protected double balance;
    protected String accountType;
    
    public Account(Person p_person, String p_iban) {
        this.person = p_person;
        this.iban = p_iban;
        this.balance = 0;
        this.accountType = "Account";
    }

    public void deposit(double p_amount) {
        System.out.println("Adding $ " + p_amount + " to balance to " + this.accountType + ".");
        this.balance += p_amount;
    }
    
    public void withdraw(double p_amount) {
        if (this.balance > p_amount) {
            System.out.println("Withdrawing $ " + p_amount + " to balance to " + this.accountType + ".");
            this.balance -= p_amount;
        } else {
            System.out.println("Withdrawing $ " + p_amount + " not possible. " + this.accountType + "'s balance is too low.");
        }
    }

    public void currentBalance() {
        Helpers.spacer();
        System.out.println("Account Owner: " + this.person.getLastName() + ", " + this.person.getFirstName());
        System.out.println("IBAN: " + this.iban);
        System.out.println("Current balance: $ " + this.balance + " on " + this.accountType + ".");
    }
}
