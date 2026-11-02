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
        // I created an empty list of doubles to hold the multiples of the number. 
        // I then created a for loop that will iterate from 1 to the length of the array. 
        // In each iteration, I multiply the number by the current index and add it to the list. 
        // Finally, I converted the list to an array and returned it.

        List<double> multiples = new List<double>();
        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }

        return multiples.ToArray();
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
        // I copied the last "amount" items from the list into "temp".
        // I removed those items from the end of the list.
        // I added them to the front of the list, so the list is rotated right.
        
        var temp = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, temp);
    }
}
