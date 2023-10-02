using System;

using namespace std;

public static void ReverseArray {
  int[] array = {1,2,3,4,5};

  foreach(int a in array) {
    Console.WriteLine(a);
  }
  array.Reverse(array);
  Console.WriteLine("Reversed Array: ");
  foreach(int value in array) {
    Console.WriteLine(value);
  }
  Console.ReadLine();
}
