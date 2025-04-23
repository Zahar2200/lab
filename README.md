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
