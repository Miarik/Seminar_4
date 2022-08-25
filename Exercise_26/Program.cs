Console.WriteLine("Введите число");
string? number = Console.ReadLine();

char[] arr = number.ToCharArray();

int GetArrayLength (char[] array)
{
    int count = array.Length;
    return count;
}

Console.WriteLine(GetArrayLength(arr));
