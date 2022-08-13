// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100); //10, 99 + 1 
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstDigit = number / 10; 
// int secondDigit = number % 10; 

// if (firstDigit == secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа {number} -> Цифры одинаковы");
// }
// else if  (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// }
// else 
// {
//     Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}");
// }

// int res = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {number} -> {res}");


int MaxDigit(int num)
{
    int firstDigit = num / 10; 
    int secondDigit = num % 10; 
    if(firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
} 

int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} -> {res}");