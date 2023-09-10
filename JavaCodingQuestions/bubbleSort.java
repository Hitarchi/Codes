import java.util.*;
class Main {
    static void bubbleSort(int array[])
    {
        int size = array.length;

        for(int i = 0; i < size; i++) {
            for(int j =0; j < size; j++) {
                if(array[j] > array[j+1]) {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }

    public static void main(String args[]) {
        int[] data = {4,65,5,76,34,23};

        Main.bubbleSort(data);

        System.out.println("Sorted Array: ");
        System.out.println(Arrays.toString(data));
    }
}
