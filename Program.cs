﻿string fraseDigitada, Ceboles;

Console.Write("Digite uma flase: ");
fraseDigitada = Console.ReadLine()!;

Ceboles = fraseDigitada
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine(Ceboles);
