using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            // error checking
            //int[] nums1 = { 4, 3, 2, 7, 8, 2, 10, -1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));
                        

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> nums_missing = new List<int>();
                // Write your code here
                int len=nums.Length;
                foreach (var j in nums)
                {
                    if (j > len | j < 1)
                    {
                        Console.WriteLine("Array elements must be between 1 and n");
                        return new List<int>();
                    };
                };
                for (int i = 1; i < len;i++) 
                { 
                    
                    if (!nums.Contains(i))
                    { 
                        nums_missing.Add(i);
                    };
                };
                if (nums_missing.Count == 0)
                {
                    Console.WriteLine("No missing values");
                };
                return nums_missing;
                
            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught!");
                //throw;
                return new List<int>();
            }
            
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                List<int> nums_odd = new List<int>();
                List<int> nums_even = new List<int>();
                
                foreach (var j in nums)
                {
                    if (j %2==0)
                    {
                        nums_even.Add(j);
                    }
                    else 
                    { 
                        nums_odd.Add(j);
                    }
                };
                nums_even.AddRange(nums_odd);
                int[] myArray = nums_even.ToArray();
                return myArray; // Placeholder
            }
            catch (Exception)
            {
                    Console.WriteLine("Exception caught!");
                    //throw;
                    return new int[0];
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                
                List<int> nums2 = new List<int>();
                Array.Sort(nums);
                
                foreach (var j in nums)
                {
                    int k = target - j;
                    if (nums.Contains(k) )
                    {
                        nums2.Add(Array.IndexOf(nums, j));
                        nums2.Add(Array.IndexOf(nums, k));
                        int[] myArray = nums2.ToArray();
                        return myArray; // Placeholder
                    };
                };
                if (nums2.Count == 0)
                {
                    Console.WriteLine("No such numbers");
                };
                int[] myArray2 = nums2.ToArray();
                return myArray2;
                

            }
            catch (Exception)
            {
                Console.WriteLine("Exception caught!");
                //throw;
                return new int[0];
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                List<int> nums_pos = new List<int>();
                List<int> nums_neg = new List<int>();
                if (nums.Length < 3) 
                {
                    Console.WriteLine("Array is too short!");
                }
                // Write your code here
                foreach (var j in nums)
                {
                    if (j >=0 )
                    {
                        nums_pos.Add(j);
                    }
                    else
                    {
                        nums_neg.Add(j);
                    }
                };
                nums_pos.Sort();
                nums_neg.Sort();
                //nope
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                int e = 0;
                int f = 0;
                if (nums_pos.Count != 0)
                {
                    a = nums_pos[^1];
                    b = nums_pos[^2];
                    c = nums_pos[^3];
                }
                if (nums_neg.Count != 0)
                {
                    d = nums_neg[1];
                    e = nums_neg[2];
                    f = nums_neg[3];
                }
                if (a * b * c > d * e * a)
                {
                    return a * b * c;
                }// Placeholder
                else
                {
                    if (d*e*f > d * e * a)
                    {
                        return d*e*f;
                    }
                    else
                    {
                        return d * e * a;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                string binary = Convert.ToString(decimalNumber, 2);
                return binary; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int low = 0, high = nums.Length - 1;

                while (low < high)
                {
                    
                    if (nums[low] <= nums[high])
                    {
                        return nums[low];
                    }
                    
                    int mid = (low + high) / 2;

                    if (nums[mid] > nums[high])
                    {
                        low = mid + 1;
                    }

                    else
                    {
                        high = mid;
                    }
                }
                return nums[low];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                
                string str=x.ToString();
                int len = str.Length;

                for (int i = 0; i < len / 2; i++)
                {

                    if (str[i] != str[len - i - 1])
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n<0 | n > 30) 
                {
                    Console.WriteLine("Choose a number between 0 and 30");
                    return 0; 
                }
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
