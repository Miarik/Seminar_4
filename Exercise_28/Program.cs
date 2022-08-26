Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberMultiplication(int num) 
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult * i;
    }
    return mult;
}
Console.WriteLine(NumberMultiplication(number));