// Calculate total sum of elements from given array.

int Calculate(int[] values)
{
    int result = 0;
    for (int i = 0; i < values.Length; i++)
    {
        result += values[i];
    }
    return result;



}

int[] testData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(Calculate(testData));