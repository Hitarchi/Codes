using System;
using namespace std;
public static void minMax {
  int[] input = {1,2,3,4,5,6,7,8,9,10};
  if(input.length == 0) {
    return;
  }
  int maxPos = 0;
  int minPos = 0;
  int valMax = 0;
  int valMin = 0;

  for(int i=1; i<input.length; i++) {
    if(input[maxPos] < input[i]) {
      maxPos = i;
    }
    if (input[minPos] > input[i]) {
      minPos = i
    }
            valMax = input[maxPos];
            valMin = input[minPos];
            input[maxPos] = valMin;
            input[minPos] = valMax;
    
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
  }
}
