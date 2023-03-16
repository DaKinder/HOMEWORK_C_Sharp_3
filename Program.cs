using System;

//Задача 19. Программа принмает на вход число и проверяет, является ли оно палиндромом.

int FindNumberLength(int input)
{   
    int numLength = 0;
    
    while(input > 0)
    {
        input = input / 10;
        numLength++;
    }
    return numLength;
}

int MathPowInt(int num, int exponentiation)
{
    int i = 1;
    int multiplier = num;
    while (i < exponentiation)
    {
        num = num * multiplier;
        i++;
    }
    return num;
}

//123 1*100 2*10 3*1 - 3*100 2*10 1*1 321

int ReverseNumber(int divider, int num, int length) //12345 10000 50000 + 4000 + 300 +20 + 1 = 54321
{
    int i = 0;
    int newNum = 0;
    while (i < length)
    {
        newNum = newNum + num % 10 * divider;
        num = num /10;
        divider = divider / 10;
        i++;
    }
    return newNum;
}

bool CheckPalindrom(int input, int reversedNum)
{
    if(input == reversedNum)
    {
        return true;
    } 
    else return false;

}

void PrintResult(bool result)
{
    if(result) System.Console.WriteLine("палиндром");
    else System.Console.WriteLine(" не палиндром");
}

Console.Write("Введите число, проверим является ли оно палиндромом: ");
int input = Convert.ToInt32(Console.ReadLine());

int length = FindNumberLength(input);

int divider = MathPowInt(10, (length -1));

int reversedNum = ReverseNumber(divider, input, length);

PrintResult(CheckPalindrom(input, reversedNum));

//Задача 21. Программа принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве

//Задача 23. Программа принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N/
