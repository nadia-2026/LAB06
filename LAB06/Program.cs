using LAB06;

Rational r1 = new Rational(1, 2);
Rational r2 = new Rational(1, 3);

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine($"Сумма: {r1 + r2}");
Console.WriteLine($"Разность: {r1 - r2}");
Console.WriteLine($"Произведение: {r1 * r2}");
Console.WriteLine($"Деление: {r1 / r2}");
Console.WriteLine($"r1 == r2: {r1 == r2}");
Console.WriteLine($"r1 > r2: {r1 > r2}");