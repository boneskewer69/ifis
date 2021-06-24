package types;

public class Employee extends Person {
    private double gehalt;

    // Standartkonstruktor
    public Employee(String p_vorname, String p_nachname) {
        super(p_vorname, p_nachname);
        this.gehalt = 10000.0 + (50000.00 * Math.random());
    }
    public Employee(double p_gehalt, String p_vorname, String p_nachname) {
        super(p_vorname, p_nachname);
        this.gehalt = p_gehalt;
    }
        
    public double getGehalt() {
        return this.gehalt;
    }

    @Override
    public void druckeDaten() {
        super.druckeDaten();
        System.out.println("\t € " + Math.round(this.gehalt));
    }
}
