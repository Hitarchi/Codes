using System;

public class LargestofThree {
    public static void Main(String[] args)
    {
        int num1,num2,num3;
        Console.Write("Enter Three Numbers : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());

        if(num1 >num2 && num1 >num3) {
            Console.WriteLine("Largest Number : "+num1);
        }
        else if(num2 >num1 && num2 >num3) {
            Console.WriteLine("Largest Number :"+num2);
        }
        else {
            Console.WriteLine("Largest Number :" +num3);
        }
    }
}