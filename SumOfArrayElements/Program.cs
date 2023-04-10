// Calculate total sum of elements from given array.

int Calculate(int[] values)
{
    int x = 0;
    foreach (var item in values)
    {
        x += item;
    }
    return x;
}

int[] testData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(Calculate(testData));