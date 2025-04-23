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
