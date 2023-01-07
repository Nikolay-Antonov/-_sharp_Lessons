int[] array = { 1, 2, 3, 5, 27, 5, 18 };

int n = array.Length;
int find = 5;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1; 
    index++;
}
