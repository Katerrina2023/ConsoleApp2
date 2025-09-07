/*
Построить иерархию классов. Млекопитающее - Тигр - Собака – Животное – Кошачьи(обзови по-английски как хочешь) – Лев
Что обязательно должно быть
1. добавить статическое поле, поле только для чтения, константу. Проинициализировать их.
2. Статический метод. Вызвать его
3 Статический конструктор 
4. Конструктор с параметрами и без(в одном классе). Создать пару объектов этого класса
 */

using System.Xml.Linq;

class Animal
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
}


class Mlekop : Animal{ }

class Dog : Mlekop { }
class Catty : Mlekop { }


class Tigr : Catty {}

class Lev : Catty { }

class Program
{
    static void Main(string[] args)
    {
        var an1 = new Animal();
        var an3 = new Animal(4);
        var an2 = new Animal("black",5,6);
        var an5 = new Animal("k", 4, 9);

        Animal.Print();

        var mlekop1 = new Mlekop();
        var dog1 = new Dog();
        var catty1 = new Catty();
        var tigr1 = new Tigr();
        var lev1 = new Lev();

    }
}