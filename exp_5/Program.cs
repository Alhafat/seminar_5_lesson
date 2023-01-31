// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
int[] GetArray ()
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

int[] findСomposition (int[] numbers)
{
    int size=numbers.Length / 2;
    if (numbers.Length % 2 != 0) size = numbers.Length / 2 + 1;
    else size = numbers.Length / 2;
    int[] newArray=new int[size];
    for (int j = 0; j <size; j++)
    {
        newArray[j]=numbers[j]*numbers[numbers.Length-1-j]; 
    }
    if (numbers.Length % 2 != 0) newArray[newArray.Length-1]=numbers[numbers.Length/2];
    // return newArray;
    // newArray=newArray.Append(123).ToArray();
    return newArray;
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));
int[] result=findСomposition(numbers);
System.Console.WriteLine(string.Join(", ",result));