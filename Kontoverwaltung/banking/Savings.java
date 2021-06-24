package banking;

public class Savings extends Account {
    protected boolean availability;

    public Savings(Person p_person, String p_iban) {
        super(p_person, p_iban);
        this.availability = false;
        this.accountType = "Savings";
    }

    public void setAvailability(boolean p_availability) {
        this.availability = p_availability;
    }

    @Override
    public void withdraw(double p_amount) {
        if (this.availability) {
            super.withdraw(p_amount);
        }
    }

    @Override
    public void currentBalance() {
        super.currentBalance();
        if (this.availability) {
            System.out.println("The " + this.accountType + " is available.");
        } else {
            System.out.println("The " + this.accountType + " is unavailable.");
        }
    }
}
