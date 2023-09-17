import java.util.Scanner;

public class Prime {
    public static void main(String[] args) {
        boolean prime=true;   
        int count=1;
        
        System.out.println("Enter number to check: ");
        Scanner sc= new Scanner(System.in);
        int in= sc.nextInt();
        
        
        for(int i=2; i<in; i++){
            if(in%i==0){
                prime = false;
                count++;                
            }
        }
        if(prime==true)
            System.out.println("Number is prime ");
        else
        {
            System.out.println("Number is not prime and it has "+ count+ " factors");
        }
    }
    
}
