// Calculate individual sum of each array in a given array. And assing each result to another array.

int[] Calculate(int[][] values)
{
    int[] sums = new int[values.Length];
    int x = 0;
    foreach (int[] value in values)
    {
        int sum = 0;
        foreach (int value2 in value)
        {
            sum += value2;
        }
        sums[x++] = sum;
    }
    return sums;

}

int[][] testData = { new int[] { 1, 2 }, new int[] { 2, 2 }, new int[] { 3, 2 } };
int[] result = Calculate(testData);
foreach (var item in result)
{
    Console.WriteLine(item);
}