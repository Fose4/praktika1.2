// 17. Напишите программу, которая 
//принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0 ) Console.WriteLine("Первая четверть.");
// else if ( x < 0 && y > 0 ) Console.WriteLine("Втоорая четверть.");
// else if ( x < 0 && y < 0 ) Console.WriteLine("Третья четверть.");
// else if ( x > 0 && y < 0 ) Console.WriteLine("Четвертая четверть.");
// else  Console.WriteLine("Введены некоректные координаты");

string GetQuater(int xc, int yc)
{
    if (xc > 0 && yc > 0 ) return"Первая четверть.";
    if ( xc < 0 && yc > 0 ) return"Втоорая четверть.";
    if ( xc < 0 && yc < 0 ) return"Третья четверть.";
    if ( xc > 0 && yc < 0 ) return"Четвертая четверть.";
    return "Введены некоректные координаты";

}

string result = GetQuater(x, y);
string result2 = GetQuater(5, 0);
Console.WriteLine(result);
Console.WriteLine(result2);










// int quater = 0;
// if (x > 0 && y > 0 ) quater = 1;
// else if ( x < 0 && y > 0 ) quater = 2;
// else if ( x < 0 && y < 0 ) quater = 3;
// else if ( x > 0 && y < 0 ) quater = 4;
// else  Console.WriteLine("Введены некоректные координаты");
// if (x !=0 && y !=0) Console.WriteLine ($"{quater} четверть");
// else Console.WriteLine("Введены некоректные координаты");