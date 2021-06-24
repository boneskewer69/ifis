package sorting;

public class SortingMechanism {
    private long start;
    private long stop;
    private String name;
    private boolean sorted;
    private boolean outputArr;
    protected int[] arr;
    
    public SortingMechanism(int[] p_arr, String p_name) {
        this.arr =       p_arr;
        this.name =      p_name;
        this.sorted =    false;

        if (this.arr.length <= 50) {
            this.outputArr = true;
        } else {
            this.outputArr = false;
        }
        
        this.printArray();
    }

    public int[] getArray() {
        return this.arr;
    }

    protected void startStopwatch() {
        this.start = System.nanoTime();
    }

    protected void stopStopwatch() {
        this.stop = System.nanoTime();
    }

    protected void printArray() {
        // Print array to console
        if (this.outputArr == false) {
            return;
        }

        if (this.sorted) {
            System.out.print(this.name + ", sorted:\t");
        } else {
            System.out.print(this.name + ", unsorted:\t");
        }

        for (int i = 0; i < this.arr.length; i++) {
            System.out.print(this.arr[i] + " ");
        }
        System.out.println("");
    }

    protected void finish() {
        this.stopStopwatch();
        this.sorted = true;
        this.printArray();
        System.out.println(this.name + " runs for:\t" + (this.stop - this.start) + "ns or " + (this.stop - this.start) / 1000000 + "ms\n");
    }
}
