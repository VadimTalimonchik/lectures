﻿// Цикл while

Console.Clear();
// Console.SetCursorPosition(10, 4); // позиция курсора с отступом от ЛЕВОГО края - 10 и от ВЕРХНЕГО края 4
// Console.WriteLine("+");

// определим вершины треугольника

// первая вершина
int xa = 40;
int ya = 1;
// вторая вершина
int xb = 1;
int yb = 30;
// третья вершина
int xc = 80;
int yc = 30;
// всё это можно записать в одну строку так: int xa = 1, int ya = 1, int xb = 1, int yb = 30, xc = 40, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0; 3) -> 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count +=1; или count++;
}