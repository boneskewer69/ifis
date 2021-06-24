package types;

public class Person {
    private String vorname;
    private String nachname;
    
    private static int instanceCount = 0;
    
    public Person(String p_vorname, String p_nachname) {
        instanceCount += 1;
        
        this.vorname = p_vorname;
        this.nachname = p_nachname;
    }

    public String getVorname() {
        return this.vorname;
    }
    public String getNachname() {
        return this.nachname;
    }
    public static int getInstanceCount() {
        return instanceCount;
    }

    public void druckeDaten() {
        System.out.print(this.nachname + ", " + this.vorname);
    }
}
