﻿// Задача 17. Напишите программу, которая принимает на вход точки (X, Y), причем X и Y не равно 0 и 
// выдает номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("введите x: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y: ");
var y = Convert.ToInt32(Console.ReadLine());


if(x > 0 && y > 0)
{
    Console.WriteLine('1');
}

else if(x < 0 && y > 0)
{
    Console.WriteLine('2');
}
else if(x < 0 && y < 0)
{
    Console.WriteLine('3');
}
else
{
    Console.WriteLine('4');
}

