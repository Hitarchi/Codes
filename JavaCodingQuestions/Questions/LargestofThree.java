import java.util.*;

public class LargestofThree {
    public static void main(String[] args) {
        System.out.println("Enter three numbers: ");
        Scanner sc = new Scanner(System.in);
        int num1 = sc.nextInt();
        int num2 = sc.nextInt();
        int num3 = sc.nextInt();

        if(num1 > num2 && num1 > num3) {
            System.out.println("Largest Number :" +num1);
        }
        else if(num2 > num1 && num2 > num3) {
            System.out.println("Largest Number: "+num2);
        }
        else {
            System.out.println("Largest Number :"+num3);
        }
    }
}
