using System;

//238.Product of Array Except Self
//Given an integer array nums, return an array answer such that answer[i]
//is equal to the product of all the elements of nums except nums[i].

//Example 1:
//Input: nums = [1, 2, 3, 4]
//Output:[24,12,8,6]

//Example 2:
//Input: nums = [-1, 1, 0, -3, 3]
//Output:[0,0,9,0,0]

namespace ProductOfArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            //Array for testing.
            int[] nums = { -1, 1, 0, -3, 3 };

            //New output array, created to be the same length as input array.
            int[] product = new int[nums.Length];

            //Loop through each key item in the dictionary.
            for (int lPointer = 0; lPointer < nums.Length; lPointer++)
            {
                //Initialising first element in pointer product, doesnt work if zero.
                product[lPointer] = 1;

                //Loop through each element within the wrray and start multiplying them together.
                for (int rPointer = 0; rPointer < nums.Length; rPointer++)
                {
                    //Skip if self.
                    if (lPointer != rPointer)
                    {
                        //Sum the products.
                        product[lPointer] = product[lPointer] * nums[rPointer];
                    }
                }
            }

            //Parse out.
            var outputString = "{";

            for (int x = 0; x < product.Length; x++)
            {
                outputString += String.Concat(product[x], ",");
            }

            outputString = outputString.Substring(0,outputString.Length - 1);
            outputString += "}";

            //And print.
            Console.WriteLine(outputString);

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

            Console.ReadKey();
        }
    }
}
