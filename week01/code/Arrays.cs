public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Create an array of double with array length of the length passed in as argument
        //Iterate for "length" times using a for-loop
        //For each loop insert the multiples of "number" of argument passed in
        //Return the array

        double[] numbers = new double[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = number * (i + 1);
        }

        return numbers; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Ensure the supplied "amount" is not less than data.Count and not zero, and data list is not null
        if (data !== null && amount < data.Count && amount < 1)
        {
            //Get the length of the list.
            int difference = data.Count - amount;
            //Create a temporary list
            List<int> list = new List<int>(amount);
            for (int i = 0; i < amount; i++)
            {
                list.Add(data[difference]);
                data.RemoveAt(difference);
            }
            //Copy the temporary list to the newly created list2
            list<int> list2 = new List<int>(list);
            //Merge the modified data list to list2
            list2.AddRange(data);
        }
        else
        {
            writeLine("Enter Amount less than " + ${ data.Count});
        }
    }
}
