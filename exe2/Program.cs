int[] NewArray(int size)
{
	int[] array = new int[size];
        Console.Write("Array [");
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
}

int Sumnoteven(int[] array)
{
	int sum = 0;

	for (int i = 0; i < array.Length; i++)
	{
			if (i % 2 == 1 && i!=0)
				sum = sum + array[i];
			else 
			    sum = sum;
	}

	return sum;
}


int[] array = NewArray(5);
Console.WriteLine();
Console.WriteLine($"Sum " + (Sumnoteven(array)));