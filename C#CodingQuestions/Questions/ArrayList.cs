using System;
using System.Collections;

class Program
{
    public static void Main()
    {
        // create an ArrayList 
        ArrayList schoolDetails = new ArrayList();
        schoolDetails.Add("Mary's");
        schoolDetails.Add("France");
        schoolDetails.Add(23);

        // access the first element 
        Console.WriteLine("First element: " + schoolDetails[0]);

        // access the second element 
        Console.WriteLine("Second element: " + schoolDetails[1]);
        schoolDetails.Add("Science");
        schoolDetails.Add(true);
        schoolDetails.Add(5);

        // display every element of myList 
        for (int i = 0; i < schoolDetails.Count; i++)
        {
            Console.WriteLine(schoolDetails[i]);
        }
        // change the value of second element 
        schoolDetails[1] = "Styles";
        Console.WriteLine("Updated second element: " + schoolDetails[1]);

      // remove "Jack" from myList
        schoolDetails.Remove("Jack");

        // iterate through myList after removing "Jack"
        for (int i = 0; i < schoolDetails.Count; i++)
        {
            Console.WriteLine(schoolDetails[i]);
        }
    }
}
