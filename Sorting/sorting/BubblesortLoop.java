package sorting;

public final class BubblesortLoop extends SortingMechanism {    
    public BubblesortLoop(int[] p_arr) {
        super(p_arr, "BubblesortL");
    }
    
    public void sortArray() {
        this.startStopwatch();

        int swaps =   0;
        int arrSize = this.arr.length;

        do {
            swaps = 0;
            for (int i = 0; i < arrSize - 1; i++) {
                if (this.arr[i] > this.arr[i + 1]) {
                    int clipboardValue = this.arr[i + 1];
                    this.arr[i + 1] = this.arr[i];
                    this.arr[i] = clipboardValue;
                    swaps += 1;
                }
            }
        } while (swaps != 0);

        this.finish();
    }
}
