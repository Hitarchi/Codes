public class Swap
 {
    public static void main(String[] args) {
        int num1=786;
        int num2=555;
        System.out.println("Before swapping Number 1: " + num1 + "  Number 2: "+ num2 );        
         
        num1=num1+num2;
        num2=num1-num2;
        num1=num1-num2;
        System.out.println("After swapping Number 1: " + num1 + "  Number 2: "+ num2 );
    }    
}
