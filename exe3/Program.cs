double[] NewArray(int size)
{
	double[] array = new double[size];
        Console.Write("Array [");
    	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]}  ");
	}
    Console.Write("]");
    return array;
	}

double MinNum(double[] array)
{
    double min = double.MaxValue;
    foreach (var i in array) 
    {
        if (i < min)
        {
            min= i;
        }
     }
    return min;
}

double MaxNum(double[] array)
{
    double max = double.MinValue;
    foreach (var i in array) 
    {
        if (i > max) 
        {
            max = i;
        }
    }
    return max;
  
}    
double[] array = NewArray(5);
Console.WriteLine();
Console.WriteLine($"" + (MaxNum(array) - MinNum(array)));