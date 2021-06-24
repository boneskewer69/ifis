package banking;

public class Deposit extends Account {
    protected double interestRate;
    protected double disposition;

    public Deposit(Person p_person, String p_iban) {
        super(p_person, p_iban);
        this.interestRate = 0.09;
    }

    public void setInterestRate(double p_interestRate) {
        this.interestRate = p_interestRate;
    }

    @Override
    public void withdraw(double p_amount) {
        System.out.println("Withdrawing $ " + p_amount + " to balance to " + this.accountType + ".");
        this.balance -= p_amount;
    }

    public void withdraw(double p_amount, double p_fee) {
        this.withdraw(p_amount + p_fee);
    }

    public void settleInterest() {
        if (this.balance < 0) {
            // -100+-100*0,09
            this.balance = this.balance + (this.balance * this.interestRate);
        }
    }
}
