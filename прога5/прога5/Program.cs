using System;
using System.Collections.Generic;

// Абстрактний клас для всіх птахів
public abstract class Bird
{
    public int Age { get; set; }

    public Bird(int age)
    {
        Age = age;
    }

    // Абстрактний метод для виведення інформації
    public abstract void DisplayInfo();
}

// Інтерфейс для птахів, які можуть літати
public interface IFlyable
{
    double MaxFlightHeight { get; set; }
    void Fly();
}

// Інтерфейс для птахів, які можуть бігати
public interface IRunnable
{
    double RunSpeed { get; set; }
    void Run();
}

// Летючі птахи, які можуть літати
public class Eagle : Bird, IFlyable
{
    public double MaxFlightHeight { get; set; }

    public Eagle(int age, double maxFlightHeight) : base(age)
    {
        MaxFlightHeight = maxFlightHeight;
    }

    public void Fly()
    {
        Console.WriteLine("Орел летить на висоті " + MaxFlightHeight + " м.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Орел, вік: {Age} років, висота польоту: {MaxFlightHeight} м");
    }
}

public class Parrot : Bird, IFlyable
{
    public double MaxFlightHeight { get; set; }

    public Parrot(int age, double maxFlightHeight) : base(age)
    {
        MaxFlightHeight = maxFlightHeight;
    }

    public void Fly()
    {
        Console.WriteLine("Папуга летить на висоті " + MaxFlightHeight + " м.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Папуга, вік: {Age} років, висота польоту: {MaxFlightHeight} м");
    }
}

// Абстрактний клас для нелетючих птахів
public abstract class FlightlessBird : Bird, IRunnable
{
    public double RunSpeed { get; set; }

    public FlightlessBird(int age, double runSpeed) : base(age)
    {
        RunSpeed = runSpeed;
    }

    public void Run()
    {
        Console.WriteLine("Біжить зі швидкістю " + RunSpeed + " км/год");
    }
}

// Нелетючі птахи
public class Ostrich : FlightlessBird
{
    public Ostrich(int age, double runSpeed) : base(age, runSpeed) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Страус, вік: {Age} років, швидкість бігу: {RunSpeed} км/год");
    }
}

public class Penguin : FlightlessBird
{
    public Penguin(int age, double runSpeed) : base(age, runSpeed) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Пінгвін, вік: {Age} років, швидкість бігу: {RunSpeed} км/год");
    }
}

// Головний клас програми
class Program
{
    static void Main()
    {
        List<Bird> birds = new List<Bird>
        {
            new Eagle(5, 3000),   // Орел, вік 5 років, висота польоту 3000 м
            new Parrot(2, 50),    // Папуга, вік 2 роки, висота польоту 50 м
            new Ostrich(4, 60),   // Страус, вік 4 роки, швидкість бігу 60 км/год
            new Penguin(3, 10)    // Пінгвін, вік 3 роки, швидкість бігу 10 км/год
        };

        foreach (var bird in birds)
        {
            bird.DisplayInfo();

            if (bird is IFlyable flyable)
                flyable.Fly();

            if (bird is IRunnable runnable)
                runnable.Run();

            Console.WriteLine();
        }
    }
}
