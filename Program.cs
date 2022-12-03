/*Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
/*
int Met(int num)
{
    int num1 = num /10 % 10;
    int result = num1;
    return result;
}
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Met(num);
Console.WriteLine("Новое число= " + result);
*/

/*Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if(numText.Length>2)
{
    Console.WriteLine("Третья цифра-" + numText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
*/



/*Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
/*
bool Met(int num)
{
    if(num==6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите цифру,обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Met(num);
Console.WriteLine(res);
*/
