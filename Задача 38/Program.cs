void InputArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 101);
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
int SumEvenNumber (int [] array)
{
    int maxNumber = array[0];
    int minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > maxNumber)
            maxNumber = array[i];
        else if (array[i] < minNumber)
            minNumber = array[i];
    return maxNumber - minNumber;
}
Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
InputArray(array);
Console.WriteLine($"Разность максимального и минимального числа = {SumEvenNumber(array)}");
