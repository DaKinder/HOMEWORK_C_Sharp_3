//Задача 19. Программа принмает на вход число и проверяет, является ли оно палиндромом.

//поиск длины числа
/*int FindNumberLength(int input) 
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
//123 = 1*100 2*10 3*1 - 1*1 2*10 3*100 = 321
//123 = (divider = 100) - 1 + 20 + 300 = 321
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
*/
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

//Проверка корректности введённого числа
int AcceptInput(string n, int point)
{
    int num;
    bool isNum;
    do
    {
        System.Console.Write($"Введите координату оси {n} точки {point}: ");
        isNum = int.TryParse(Console.ReadLine(), out num);
    }
    while(!isNum);
    return num;
}

int j = 0;
string axis = "X";
int point = 1;
int[] arr = new int[6];
for(int i = 0; i <= 5 ; i++)
{
    if(j == 3) point = 2;
    if(j == 1 || j == 4) axis = "Y";
    else if(j == 2 || j == 5) axis = "Z";
    else axis = "X";
    arr[j] = AcceptInput(axis, point);
    j++;
}

double CountVectorLength(int [] array)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((arr[3] - arr[0]), 2) + Math.Pow((arr[4] - arr[1]), 2) + Math.Pow((arr[5] - arr[2]), 2)), 2);
    return result;
}

double result = CountVectorLength(arr);

System.Console.WriteLine(result);

//System.Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}, {arr[5]}");







/*int x1 = 
int y1 = AcceptInput("y2");
int x2 = AcceptInput("x2");
int y2 = AcceptInput("y2");
int x3 = AcceptInput("x3");
int y3 = AcceptInput("y3");*/

//System.Console.WriteLine($"{x1}, {y2}, {x2}, {y2}, {x3}, {y3}");




