package types;

public class Customer extends Person {
    private int kundennr;

    public Customer(int p_kundennr, String p_vorname, String p_nachname) {
        super(p_vorname, p_nachname);
        this.kundennr = p_kundennr;
    }

    public int getKundennr() {
        return this.kundennr;
    }

    @Override
    public void druckeDaten() {
        super.druckeDaten();
        System.out.println("\t Kd-NR.: " + this.kundennr);
    }
}
