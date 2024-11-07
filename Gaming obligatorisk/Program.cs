// See https://aka.ms/new-console-template for more information
using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.Cretures;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;
using System.Diagnostics;
using Mandatory2DGameFramework.model.MyLogger;

Console.WriteLine("Hello, World!");

var logger = MyLogger.Instance;
logger.AddListener(new ConsoleTraceListener());

// Simpel konfiguration direkte i koden for demonstration
World world = new World(10, 10);
logger.Log("World created with dimensions 15x15.");

Hero hero = new Hero("Hero", 100, 0, 0);
world.AddCreature(hero);
logger.Log($"Hero created with 100 HP at (0,0).");

Enemy enemy = new Enemy("Enemy", 50, 2, 2);
world.AddCreature(enemy);
logger.Log($"Enemy created with 50 HP at (2,2).");

// Tilføjer våben og forsvar til helten
AttackItem sword = new AttackItem("Sword", 10, 1, 1, 1, true);
DefenceObject shield = new DefenceObject("Shield", 5, 1, 1, true);
hero.AttackItems.Add(sword);
hero.DefenceItems.Add(shield);
logger.Log("Hero equipped with Sword and Shield.");

// Simuler et angreb i verdenen
logger.Log($"{enemy.Name} starts with {enemy.HitPoints} HP.");
hero.Hit(enemy, sword.HitPoint);
logger.Log($"{enemy.Name} has {enemy.HitPoints} HP after being hit.");

// Output resultater
Console.WriteLine($"{enemy.Name} has {enemy.HitPoints} HP after being hit by {hero.Name}.");