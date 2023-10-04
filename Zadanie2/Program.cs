Console.WriteLine("Проверка числа на палиндромность");
Console.Write("Введите число для проверки: ");
int number = int.Parse(Console.ReadLine());

bool isPalindrome = IsPalindrome(number);

if (isPalindrome)
{
    Console.WriteLine($"Число {number} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом.");
}

static bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }

    return originalNumber == reversedNumber;
}