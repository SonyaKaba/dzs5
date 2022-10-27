Array();
void Array()
{
    int[] N = new int[4];
    Console.Write("Array [ ");
    int count = 0;
    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(100, 999);
        Console.Write($"{N[i]} ");
        if (N[i] % 2 == 0) count++;
    }
   
    Console.Write("]");
    Console.WriteLine($" even numbers {count}");
}
    
