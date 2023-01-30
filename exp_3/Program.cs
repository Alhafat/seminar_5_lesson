// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();


int [] GetArray()
{
    System.Console.WriteLine("Введите количество элементов массива: ");
    int size=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите минимальное значение элемента массива: ");
    int minValue=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите максимальное значение элемента массива: ");
    int maxValue=int.Parse(Console.ReadLine()!);
    int[] array=new int[size];
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}

void findNumber (int[] numbers)
{
    Console.WriteLine("Введите искомое число: ");
    int number=int.Parse(Console.ReadLine()!);
    foreach (int number1 in numbers)
    {
        if (number1==number) 
        {
            Console.WriteLine($"Искомое число {number} присутствует в массиве");
            return;
        }
    }
    Console.WriteLine($"Искомое число {number} отсутствует в массиве");
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));

findNumber(numbers);