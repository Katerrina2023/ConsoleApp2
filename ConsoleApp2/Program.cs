/*
Построить иерархию классов. Млекопитающее - Тигр - Собака – Животное – Кошачьи(обзови по-английски как хочешь) – Лев
Что обязательно должно быть
1. добавить статическое поле, поле только для чтения, константу. Проинициализировать их.
2. Статический метод. Вызвать его
3 Статический конструктор 
4. Конструктор с параметрами и без(в одном классе). Создать пару объектов этого класса
 */

using System.Xml.Linq;

interface IPlayable
{
    void Play();
}

public abstract class Animal
{
    public readonly int ID;
    public int Age = 1;
    public string Color;
    public const string Name = "Kto-to";
    public static int instances; 

    public Animal(int id)
    {
        ID = id;
        instances++;
    }

    public static void Print()
    {
        Console.WriteLine($"Имя: {Name}  кол-во: {instances}");
    }

    static Animal()
    {
        instances= 0;
    }

    public Animal (string color, int id, int age)
    {
        Color = color;
        ID = id;
        Age = age;
        instances++;
    }
    public Animal() { instances++; }

    public abstract void MakeSound();
    public virtual void Eat()
    {
        Console.WriteLine("Животное ест");
    }

}


class Mlekop : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Млекопитающее издаёт звук");
    }
}

class Dog : Mlekop, IPlayable {
    public override void MakeSound()
    {
        Console.WriteLine("Гав-гав");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака ест корм");
    }

    public void Play()
    {
        Console.WriteLine("Собака играет с мячом");
    }

}

public static class Extensions
{
    public static void Describe(this Animal animal)
    {
        Console.WriteLine($"ID: {animal.ID}, Age: {animal.Age}, Color: {animal.Color}");
    }

    public static string AddDots(this string str)
    {
        return "..." + str;
    }
}

class Catty : Mlekop { }


class Tigr : Catty {}

class Lev : Catty { }

class Program
{
    static void Main(string[] args)
    {
  

        Animal.Print();

        var mlekop1 = new Mlekop();
        var dog1 = new Dog();
        var catty1 = new Catty();
        var tigr1 = new Tigr();
        var lev1 = new Lev();


        string a = "abc";
        string b = a.AddDots();

        dog1.Describe();
    }
}