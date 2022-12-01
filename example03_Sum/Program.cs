// сложение двух чисел

// когда уже заданы числа
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

// когда уже заданы числа, с введением дополнительной переменной result
// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// Генератор случайных чисел new Random().Next(min, max)
// числа задаются при помощи генератора случайных чисел
int numberA = new Random().Next(1, 10); // генерируются числа от 1 2 3 ... и до 9
Console.WriteLine(numberA); // выводится сгенерированное число в консоль
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
