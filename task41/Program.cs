int[] GetArray (int n) 
{
   int[] array = new int[n];
   for (int i = 0; i < n; i++)
   {
       Console.Write("Введите число: ");
       int a = Convert.ToInt32(Console.ReadLine());
       array[i] = a;     
   }
   return array;
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = GetArray(n);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
int count = 0;
for(int i = 0; i < mas.Length; i++)
{
   if(mas[i] > 0)
   {
      count++;
   }
}
Console.WriteLine($"Кол-во элементов > ноля: {count}");