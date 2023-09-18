import java.util.*;

public class Fabonacci {
    static int n1 =0, n2 = 1, n3= 0;
    static void printFabonacci (int count)
    {
        if(count >0)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = 3;
            System.out.println(" "+n3);
            printFabonacci(count -1);
        }
    }
    public static void main(String args[]) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter number : ");
        int count = sc.nextInt();
        System.out.println(n1+ " " +n2);
        printFabonacci(count - 2);
    }
}
