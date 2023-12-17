using System;

//Клас, який представля об'єкт, який ми створюємо
class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }
    public string PartC { get; set; }

    public void Display()
    {
        Console.WriteLine($"PartA: {PartA}, PartB: {PartB}, PartC: {PartC}");
    }
}

// Абстрактний будівельник, що визначає спосіб побудови об'єкта
abstract class Builder
{
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract void BuildPartC();
    public abstract Product GetResult();
}

// Конкретний будівельник, що реалізує конкретний спосіб побудови об'єкта
class ConcreteBuilder : Builder
{
    private Product product = new Product();

    public override void BuildPartA()
    {
        product.PartA = "PartA built";
    }

    public override void BuildPartB()
    {
        product.PartB = "PartB built";
    }

    public override void BuildPartC()
    {
        product.PartC = "PartC built";
    }

    public override Product GetResult()
    {
        return product;
    }
}

// Клас, який використовує будівельника для побудови об'єкта
class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта Director
        Director director = new Director();

        // Створення об'єкта будівельника
        Builder builder = new ConcreteBuilder();

        // Директор вказує будівельнику побудувати об'єкт
        director.Construct(builder);

        // Отримання результату від будівельника
        Product product = builder.GetResult();

        // Відображення результату
        product.Display();

        // Закомітіть цей код у ваш репозиторій та створіть пулл-реквест на main гілку.
    }
}