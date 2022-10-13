string[] arrayStart = new string[5] { "321", "12345", "hello", "world", "Rus" };
string[] arrayEnd = new string[arrayStart.Length];

void GetArrayEnd(string[] arrayStart, string[] arrayEnd) 
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if (arrayStart[i].Length <= 3)
        {
            arrayEnd[count] = arrayStart[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)  Console.Write($"{array[i]}  ");
    Console.WriteLine();
}

System.Console.WriteLine("начальный массив");
PrintArray(arrayStart);
GetArrayEnd(arrayStart, arrayEnd);
System.Console.WriteLine("итоговый массив - элементы длиной меньше или равно 3");
PrintArray(arrayEnd);

