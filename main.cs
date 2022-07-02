//Task 1
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.
 

// Example 1:

// Input: x = 121
// Output: true
// Explanation: 121 reads as 121 from left to right and from right to left.

// Example 2:

// Input: x = 10
// Output: false
// Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

using System;

class Program {

public static void Main(string[] args) {
  Console.WriteLine (IsPalindrome(1234321));
}
  
    public static bool IsPalindrome(int x) {
      bool palindrome = false;
        int digits = CheckDigits(x);
      for(int i=0;i<digits/2;i++){
        if(x%(10+(10*i)) != x%((MathF.Pow(10,digits-1))-(10*(digits/2)))){
          // 1234321 % (10 + (10 * 0)) != 1234321%((7*10)-(10*(7/2)))
          // 7 ^ 10 = 70000000 OR  10 ^ 7 = 10000000
          return false;
        }
      }
      return palindrome;
    }

  public static int CheckDigits(int no){
    int digits = 1;
    while(no/10>0){
      digits++;
      no = no/10;
    }
    return digits;
  }
}


//Task 2
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 

// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]


class Program {
  
  public static void Main(string[] args) {
    int [] nums = new int[] { 1, 3, 5, 7, 10, -5, 15, 4};
    int[] result = twoSum(nums, 14);
    
  }

  public static int[] twoSum(int[] nums, int target) {
    // code here
    int[] result = new int[2];

    
    for(int i = 0 ; i < nums.Length -1 ; i++){
      for(int j = i ; j < nums.Length ; j++){
        if(nums[i]+nums[j] == target){
          result[0] = i;
          result[1] = j;
          break;
        }
      }
    }
    return result;
 
    }
}

//Interviewer comments
// improvements
// 1. trick is a + b = c can also be seen as c - b = a
// 2. sort array? n*log(n) and do binary search
// 3. use tree
// 4. use hashmap/dictionary that will reduce one loop to O(1)