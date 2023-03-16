//Задача 19. Программа принмает на вход число и проверяет, является ли оно палиндромом.

//поиск длины числа
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

 //возведение 10 в степень длины числа чтобы получить divider
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

//Принцып разворота числа. Сам придумал, без гугла
//123 = 1*100 2*10 3*1 - 3*100 2*10 1*1 = 321
//12345 =  (divider = 100) - 300 + 20 + 1 = 321
int ReverseNumber(int divider, int num, int length) 
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

 //проверка числа на палиндромность
bool CheckPalindrom(int input, int reversedNum)
{
    if(input == reversedNum)
    {
        return true;
    } 
    else return false;

}

 //вывод в консоль
void PrintResult(bool result)
{
    if(result) System.Console.WriteLine("палиндром");
    else System.Console.WriteLine(" не палиндром");
}

//блок ввода польхователем
Console.Write("Введите число, проверим является ли оно палиндромом: ");
int input = Convert.ToInt32(Console.ReadLine());

//блоки обработки входящей информации
int length = FindNumberLength(input);
int divider = MathPowInt(10, (length -1));
int reversedNum = ReverseNumber(divider, input, length);

//блок вывода информации
PrintResult(CheckPalindrom(input, reversedNum));