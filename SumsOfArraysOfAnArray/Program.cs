// Calculate individual sum of each array in a given array. And assing each result to another array.

int[] Calculate(int[][] values)
{
    int[] results = new int[values.Length];
    for (int i = 0; i < values.Length; i++)
    {
        int sum = 0;
        for (int j = 0; j < values[i].Length; j++)
        {
            sum += values[i][j];
        }
        results[i] = sum;
    }
    return results;
}

int[][] testData = { new int[] { 1, 2 }, new int[] { 2, 2 }, new int[] { 3, 2 } };
int[] results = Calculate(testData);