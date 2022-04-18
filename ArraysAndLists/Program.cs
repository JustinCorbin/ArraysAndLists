using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ArraysAndLists
{
    public static class ArraysAndLists
    {
        // 1- When you post a message on Facebook, depending on the number of people who like your
        // post, Facebook returns different information.

        // Write a method that accepts any number of names.
        // Return a string based on the below pattern.
        // If no one likes your post, it returns an empty string.
        // If only one person likes your post, it returns: "[Friend's Name] liked your post."
        // If two people like your post, it returns: "[Friend 1] and [Friend 2] liked your post."
        // If more than two people like your post, it returns: "[Friend 1], [Friend 2] and [Number of Other People] others liked your post."
        public static string FacebookLikes(params string[] names)
        {
            if (names.Length == 0)
            {
                return string.Empty;
            }
            else if (names.Length == 1)
            {
                return (names[0] + " liked your post.");
            }
            else if (names.Length == 2)
            {
                return (names[0] + " and " + names[1] + " liked your post.");
            }
            else
            {
                return names[0] + ", " + names[1] + " and " + (names.Length - 2) + " others liked your post.";
            }
        }

        // 2 - Write a method that accepts any number of integers (minimum of two integers). If an
        // integer is a duplicate, return "Error". If all integers are unique, then order them in
        // ascending order and return the sorted result as a string of integers separated by spaces.
        public static string NumberSorter(params int[] numbers)
        {
            if (numbers.Count() != numbers.Distinct().Count())
            {
                return "Error";
            }
            else 
            {
                string final = "";
                Array.Sort(numbers);
                foreach (int i in numbers)
                {
                    final += i.ToString() + " ";
                }
                return final.Trim();
            }
        }

        // 3 - Write a method that accepts a string for a name. Use an array to reverse the characters
        // then return the result as a string. "I like trains" should return "sniart ekil I". Return
        // "Error" if no text is inputted.
        public static string ReverseName(string name)
        {
            String final = "";
            if (name != "")
            {
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    final += name[i];
                }
                return final;
            }
            else
            {
                return "Error";
            }
        }

        // 4 - Write a method that accepts any number of integers. If none or less than 5 numbers,
        // return "Invalid Array"; otherwise, return the 3 smallest numbers as a string separated by
        // spaces, sorted in ascending order. Treat duplicate numbers normally.
        public static string SmallestNumbers(params int[] numbers)
        {
            if (numbers.Length < 5)
            {
                return "Invalid Array";
            }
            else
            {
                Array.Sort(numbers);
                String final = numbers[0].ToString() + " " + numbers[1].ToString() + " " + numbers[2].ToString();
                return final;
            }
        }

        // 5 - Write a method that accepts any number of numbers (assume at least two numbers). The numbers
        // may include duplicates. Return the distinct numbers as an array sorted by ascending order.
        // So for example, an array consisting of [2, 2, 1, 3] should return an integer array of {1, 2, 3}. 
        public static int[] UniqueNumbers(params int[] numbers)
        {
            List<int> final = new List<int>();
            foreach (int i in numbers)
            {
                if (!final.Contains(i))
                {
                    final.Add(i);
                }
            }
            final.Sort();
            return final.ToArray();
        }

        private static class Program
        {
            private static void Main()
            {
                // Use this section to test code should you feel the need.
                // Console.WriteLine(whatever);        
            }
        }
    }
}
