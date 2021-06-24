import java.util.concurrent.ThreadLocalRandom;

import sorting.*;

public class Main {
    public static void main(String[] args) {
        int sizeOfArr =                       1000000;
        int randomThreshold =                 sizeOfArr * 2;
        
        int[] randomArrQuicksort =            new int[sizeOfArr];
        int[] randomArrBubblesortLoop =       new int[sizeOfArr];
        int[] randomArrBubblesortRecrusion =  new int[sizeOfArr];

        // fill array with sample data
        for (int i = 0; i < sizeOfArr; i++) {
            int generatedNumber = ThreadLocalRandom.current().nextInt(0, randomThreshold + 1);

            randomArrQuicksort[i] =           generatedNumber;
            randomArrBubblesortLoop[i] =      generatedNumber;
            randomArrBubblesortRecrusion[i] = generatedNumber;
        }

        System.out.println("Current Size of Array: " + sizeOfArr + "\n");

        Quicksort exampleQuicksort = new Quicksort(randomArrQuicksort);
        exampleQuicksort.sortArray();

        BubblesortLoop exampleBubblesortLoop = new BubblesortLoop(randomArrBubblesortLoop);
        exampleBubblesortLoop.sortArray();

        // BubblesortRecursion exampleBubblesortRecursion = new BubblesortRecursion(randomArrBubblesortRecrusion);
        // exampleBubblesortRecursion.sortArray();
    }
}
