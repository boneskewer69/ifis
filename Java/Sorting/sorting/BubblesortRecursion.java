package sorting;

public final class BubblesortRecursion extends SortingMechanism {
    public BubblesortRecursion(int[] p_arr) {
        super(p_arr, "BubblesortR");
    }
    
    public void sortArray() {
        this.startStopwatch();

        this.bubblesort();

        this.finish();
    }

    private void bubblesort() {
        int swaps = 0;
        int arrSize = this.arr.length;

        for (int i = 0; i < arrSize - 1; i++) {
            if (this.arr[i] > this.arr[i + 1]) {
                int clipboardValue = this.arr[i + 1];
                this.arr[i + 1] = this.arr[i];
                this.arr[i] = clipboardValue;
                swaps += 1;
            }
        }
        
        if (swaps != 0) {
            this.bubblesort();
        }
    }
}
