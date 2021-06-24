package sorting;

public final class Quicksort extends SortingMechanism {
    public Quicksort(int[] p_arr) {
        super(p_arr, "Quicksort");
    }
    
    public void sortArray() {
        this.startStopwatch();
        
        this.quicksort(0, this.arr.length - 1);
        
        this.finish();
    }

    private void quicksort(int begin, int end) {
        if (begin >= end) {
            return;
        }

        int partitionIndex = this.partition(begin, end);
        this.quicksort(begin, partitionIndex - 1);
        this.quicksort(partitionIndex + 1, end);
    }

    private int partition(int begin, int end) {
        int index =      begin;
        int pivotPoint = this.arr[end];

        for (int i = begin; i < end; i++) {
            if (this.arr[i] <= pivotPoint) {
                int temp = this.arr[index];
                this.arr[index] = this.arr[i];
                this.arr[i] = temp;
                index += 1;
            }
        }

        int clipboardValue = this.arr[index];
        this.arr[index] =    pivotPoint;
        this.arr[end] =      clipboardValue;

        return index;
    }
}
