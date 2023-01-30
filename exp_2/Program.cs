// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[] GetArray ()
{
    System.Console.WriteLine("Введите количество элементов массива");
    int length=int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("Введите минимальное значение элемента массива");
    int min=int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("Введите максимальное значение элемента массива");
    int max=int.Parse(Console.ReadLine()!);
    int[] array= new int[length];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    return array;
}

int[] newArray (int[] paramNumbers)
{
    var array = paramNumbers.ToArray();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]*=-1;
    }
    return array;
}

int[] numbers=GetArray();
int[] result=newArray(numbers);
Console.WriteLine($"Массив {string.Join(", ", numbers)} заменен массивом {string.Join(", ", result)}");