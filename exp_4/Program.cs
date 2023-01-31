// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] GetArray()
{
    System.Console.WriteLine("Введите количество элементов массива");
    int size=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите миниммальное значение элемента массива");
    int min=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите максимальное значение элемента массива");
    int max=int.Parse(Console.ReadLine()!);
    int[] array= new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    return array;
}

int findNumber (int[] numbers)
{
    int count=0;
    foreach (int number1 in numbers)
    {
        if ((number1<100)&&(number1>=10)) count++;
    }
    return count;
}

int[] numbers=GetArray();
int result=findNumber(numbers);
System.Console.WriteLine(string.Join(", ", numbers));
System.Console.WriteLine($"Встречается {result} раз(а)");