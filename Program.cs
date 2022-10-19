// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Вопрос, есть ли система которая будет проверять что вводит пользователь, например он вводит (А, И, 5, у, 0) и система ему говорит 
// "Некоректный ввод данных" 
Console.WriteLine("Введите числа через запятую; ");
string num = Console.ReadLine()!;
int[] arr = Array.ConvertAll(num.Split(", "), int.Parse);
int count = 0;
for (int j = 0; j < arr.Length; j++)
if (arr[j] > 0) count++; 
Console.WriteLine($"Кол-во элементов больше 0 ->> {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение: 
// 1. приравниваем правые части данных равенств, потому что они обе равны y:
//  k1*x+b1=k2*x+b2,  выразим отсюда x: x=(b2-b1)/(k1-k2)
// Затем подставим полученное значение х в выражение для у (для любого, например первого) :
//         y=k1(b2-b1)/(k1-k2)+b1
// 2. Ответ: 
//         x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1

double k1 = ReadLine("Add k1: ");
double k2 = ReadLine("Add k2: ");
double b1 = ReadLine("Add b1: ");
double b2 = ReadLine("Add b2: ");
// Этот кусочк кода выводит два знака после зяпятой. Я не смог придумать ни чего лучше. Можно как то через f но я не допер как(.
double A = PointinteretX(k1,k2,b1,b2);
A = Math.Round(A, 2);
double B = PointinteretY(k1,k2,b1,b2);
B = Math.Round(A, 2);
// Первый вариянт вывода с сокращением.
Console.WriteLine($"Точка пересечения двух прямых X = {A}; Y = {B}");
// Первый вариянт вывода Без сокращением.
//Console.WriteLine($"Точка пересечения двух прямых X = {PointinteretY(k1,k2,b1,b2)}; Y = {PointinteretX(k1,k2,b1,b2)}");
double PointinteretX (double k1,double k2,double b1,double b2)
{
    double x = (b2 - b1)/(k1-k2);
    return x;
    
}
double PointinteretY (double k1,double k2,double b1,double b2)
{
    double y = k1*(b2-b1)/(k1 -k2) + b1;
    return y;
}


// Метот запроса значений в double.
double ReadLine(string massage)
{
    Console.Write(massage);
    double num = Convert.ToDouble(Console.ReadLine()!);
    return num;
}
