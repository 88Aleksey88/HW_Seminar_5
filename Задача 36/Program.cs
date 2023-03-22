void InputArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
int SumEvenNumber (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}
Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {SumEvenNumber(array)}");