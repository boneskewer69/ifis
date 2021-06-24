/**
 *
 * Beschreibung
 *
 * @version 1.0 vom 30.10.2020
 * @author 
 */

public class Hauptklasse {
  
  public static void main(String[] args) {
    A einA = new A(1);
    System.out.println(einA.getA());
    
    B einB = new B(-5, "Hallo");
    System.out.println(einB.getA());
    System.out.println(einB.getB());
  } // end of main

} // end of class Hauptklasse

