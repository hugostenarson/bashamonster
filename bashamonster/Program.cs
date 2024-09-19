using System;

Enemy theEnemy = new Enemy();
Knight theKnight = new Knight();

Console.WriteLine($"{theKnight.name} has {theKnight.health} health.");
Console.WriteLine($"{theEnemy.name} has {theEnemy.health} health and {theEnemy.size} size.");

Console.WriteLine("ATTACK!");
theEnemy.health -= 10;

Console.WriteLine($"{theEnemy.name} now has {theEnemy.health} health.");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
