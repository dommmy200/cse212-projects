using System;
using System.Collections.Generic;
using System.Linq;

namespace MyExamples
{
    public class DuplicateCounter
    {
        public static Dictionary<int, int> CountDuplicates(int[] data)
        {
            // Create a dictionary to store the count of each number
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Create a HashSet to store unique numbers
            HashSet<int> uniqueNumbers = new HashSet<int>();

            // Iterate through the data array
            foreach (int num in data)
            {
                // If the number is not already in the HashSet, add it
                if (uniqueNumbers.Add(num))
                {
                    // If the number is unique, add it to the dictionary with a count of 1
                    frequency[num] = 1;
                }
                else
                {
                    // If the number is already in the HashSet, increment its count in the dictionary
                    frequency[num]++;
                }
            }

            return frequency;
        }
    }
}
