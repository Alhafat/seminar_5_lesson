// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] array= new int[size];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

System.Console.WriteLine("Введите количество элементов массива");
int size=int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите минимальное значение элемента массива");
int minValue=int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите максимальное значение элемента массива");
int maxValue=int.Parse(Console.ReadLine()!);

int[] numbers=GetArray(size, minValue, maxValue);
Console.WriteLine(string.Join(", ", numbers));

int[] newArray (int size)
{
    var array = numbers.ToArray();
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i]*=-1;
    }
    return array;
}

numbers=newArray(size);
Console.WriteLine(string.Join(", ", numbers));
