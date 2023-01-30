// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна 
// -20

Console.Clear();

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] array=new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]= new Random().Next(minValue,maxValue+1);
    }
    return array;
}

System.Console.WriteLine("Введите количество значений массива:");
int size=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите минимальное значение массива:");
int minValue=int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите максимальное значение массива:");
int maxValue=int.Parse(Console.ReadLine()!);
int [] numbers=GetArray(size, minValue, maxValue);
Console.WriteLine(string.Join(", ", numbers));

int summNegative=0;
int summPositive=0;

foreach (int number in numbers)
{
    // if (number<0) summNegative+=number; 
    summNegative+= number<0 ? number :0;
    // else summPositive+=number;
    summPositive+= number>0 ? number :0;
}

System.Console.WriteLine($"Сумма отрицательных значений массива = {summNegative}");
System.Console.WriteLine($"Сумма положительных значений массива = {summPositive}");