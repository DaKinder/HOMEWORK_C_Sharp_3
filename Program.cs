//Задача 19. Программа принмает на вход число и проверяет, является ли оно палиндромом.

//поиск длины числа
int FindNumberLength(int input)
{
    int numLength = 0;

    while (input > 0)
    {
        input = input / 10;
        numLength++;
    }
    return numLength;
}

//возведение 10 в степень длины числа чтобы получить divider
int MathPowInt(int num, int exponentiation)
{
    int multiplier = num;
    for (int i = 1; i < exponentiation;  i++)
    {
        num = num * multiplier;
    }
    return num;
}

//Принцып разворота числа. Сам придумал, без гугла
//123 = 1*100 2*10 3*1 - 1*1 2*10 3*100 = 321
//123 = (divider = 100) - 1 + 20 + 300 = 321
int ReverseNumber(int multiplier, int num, int length)
{
    int newNum = 0;
    for (int i = 0; i < length; i++)
    {
        newNum = newNum + num % 10 * multiplier;
        num = num / 10;
        multiplier = multiplier / 10;
    }
    return newNum;
}

//проверка числа на палиндромность
bool CheckPalindrom(int input, int reversedNum)
{
    if (input == reversedNum)
    {
        return true;
    }
    else return false;
}

//вывод в консоль
void PrintResult(bool result)
{
    if (result) System.Console.WriteLine("палиндром");
    else System.Console.WriteLine(" не палиндром");
}

//блок ввода пользователем
Console.Write("Введите число, проверим является ли оно палиндромом: ");
int input = Convert.ToInt32(Console.ReadLine());

//блоки обработки входящей информации
int length = FindNumberLength(input);
int divider = MathPowInt(10, (length - 1));
int reversedNum = ReverseNumber(divider, input, length);

//блок вывода информации
PrintResult(CheckPalindrom(input, reversedNum));






//Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

//Проверка корректности введённого числа(блок ввода пользователем)
int AcceptUserInput(string n, int point)
{
    int num;
    bool isNum;
    do
    {
        System.Console.Write($"Введите координату оси {n} точки {point}: ");
        isNum = int.TryParse(Console.ReadLine(), out num);
    }
    while (!isNum);
    return num;
}

//блок подсчёта длины вектора
double CountVectorLength(int[] arr)
{
    return Math.Round(Math.Sqrt(Math.Pow((arr[3] - arr[0]), 2) + Math.Pow((arr[4] - arr[1]), 2) + Math.Pow((arr[5] - arr[2]), 2)), 2);
}

//блок создания и заполнения массива
int[] CreateArray()
{
    string axis = "X";
    int point = 1;
    int[] arr = new int[6];

    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        //меняет номер точки
        if (j == 3) point = 2;

        //меняет ось
        if (j == 1 || j == 4) axis = "Y";
        else if (j == 2 || j == 5) axis = "Z";
        else axis = "X";

        //заполнение массива
        arr[j] = AcceptUserInput(axis, point);
        j++;
    }
    return arr;
}

int[]arr = CreateArray();
Console.WriteLine(CountVectorLength(arr));






//Задача 23. Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

//блок вывода
void PrintTable(int numberN)
{
    for (int i = 1; i <= numberN; i++)
    {
        Console.WriteLine($"{i} ^ {3} = {MathPowInt(i, 3)}"); //обращение к методу из первой задачи (^.^)
    }
}

//блок ввода пользователем
int UserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите целое число: ");
PrintTable(UserInput());
