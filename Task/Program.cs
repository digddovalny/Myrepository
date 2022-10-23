//проверяем условие символов
string[] SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
    return arr2;
}
//печатаем массив 
void Print1DArray(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


string[] array1 = new string[] { "123", ":-)", "hello", "world", "res" };
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
Print1DArray(array2);