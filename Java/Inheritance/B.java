
// Unterklasse
class B extends A {
  private String b;
  
  public B(int a, String b) {
    super(a);
    this.b = b;
  }
  
  public String getB() {
    return b;
  }
}
