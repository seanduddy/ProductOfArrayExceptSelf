using System;
using System.Collections.Generic;
using System.Linq;

//238.Product of Array Except Self
//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

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
            int[] nums = { 1, 2, 3, 4 };

            //Two dictionaries, tbh could have down this with arrays but sall good man.
            var dictionary = new Dictionary<int, int>();
            var dictionaryProduct = new Dictionary<int, int>();

            //Load array into dictionary.
            for (int x = 0; x < nums.Length; x++)
            {
                dictionary.Add(x, nums[x]);
            }

            //Loop through each key item in the dictionary.
            foreach (KeyValuePair<int, int> element in dictionary)
            {
                //Initialising variable, doesnt work if zero.
                var product = 1;

                //Loop through each element within the wrray and start multiplying them together.
                for (int x = 0; x < nums.Length; x++)
                {
                    //Skip if self.
                    if (x != element.Key)
                    {
                        //Sum the products.
                        product = product * nums[x];
                        //Store in dictionary.
                        dictionaryProduct[element.Key] = product;
                    }
                }
            }

            //Parse out.
            var outputString = "{";

            foreach (KeyValuePair<int, int> element in dictionaryProduct)
            {
                outputString += String.Concat(element.Value, ",");
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
