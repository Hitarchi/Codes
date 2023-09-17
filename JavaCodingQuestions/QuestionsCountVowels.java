import java.util.*;
public class CountVowels {
    public static void main(String[] args) {
        int count = 0, count1 = 0;
        System.out.println("Enter String : ");
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        char[] chars = str.toCharArray();

        for(char c: chars) {
            if(c=='a' || c=='e' || c=='i' || c=='o' || c=='u' ) {
                count++;
            }
        }
        System.out.println("Number of vowels in string = " +count);

    }
}
