using System;

// Абстрактний клас або інтерфейс для екрану
public interface IScreen
{
    void Display();
}

// Конкретний клас для екрану смартфона
public class SmartphoneScreen : IScreen
{
    public void Display()
    {
        Console.WriteLine("Smartphone Screen Displaying");
    }
}

// Конкретний клас для екрану ноутбука
public class LaptopScreen : IScreen
{
    public void Display()
    {
        Console.WriteLine("Laptop Screen Displaying");
    }
}

// Конкретний клас для екрану планшета
public class TabletScreen : IScreen
{
    public void Display()
    {
        Console.WriteLine("Tablet Screen Displaying");
    }
}

// Абстрактний клас або інтерфейс для процесора
public interface IProcessor
{
    void Process();
}

// Конкретний клас для процесора смартфона
public class SmartphoneProcessor : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Smartphone Processor Processing");
    }
}

// Конкретний клас для процесора ноутбука
public class LaptopProcessor : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Laptop Processor Processing");
    }
}

// Конкретний клас для процесора планшета
public class TabletProcessor : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Tablet Processor Processing");
    }
}

// Абстрактний клас або інтерфейс для камери
public interface ICamera
{
    void Capture();
}

// Конкретний клас для камери смартфона
public class SmartphoneCamera : ICamera
{
    public void Capture()
    {
        Console.WriteLine("Smartphone Camera Capturing");
    }
}

// Конкретний клас для камери ноутбука
public class LaptopCamera : ICamera
{
    public void Capture()
    {
        Console.WriteLine("Laptop Camera Capturing");
    }
}

// Конкретний клас для камери планшета
public class TabletCamera : ICamera
{
    public void Capture()
    {
        Console.WriteLine("Tablet Camera Capturing");
    }
}

// Абстрактний клас або інтерфейс для фабрики компонентів
public interface IComponentFactory
{
    IScreen CreateScreen();
    IProcessor CreateProcessor();
    ICamera CreateCamera();
}

// Конкретна фабрика для смартфона
public class SmartphoneFactory : IComponentFactory
{
    public IScreen CreateScreen()
    {
        return new SmartphoneScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new SmartphoneProcessor();
    }

    public ICamera CreateCamera()
    {
        return new SmartphoneCamera();
    }
}

// Конкретна фабрика для ноутбука
public class LaptopFactory : IComponentFactory
{
    public IScreen CreateScreen()
    {
        return new LaptopScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new LaptopProcessor();
    }

    public ICamera CreateCamera()
    {
        return new LaptopCamera();
    }
}

// Конкретна фабрика для планшета
public class TabletFactory : IComponentFactory
{
    public IScreen CreateScreen()
    {
        return new TabletScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new TabletProcessor();
    }

    public ICamera CreateCamera()
    {
        return new TabletCamera();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть тип продукту (smartphone, laptop, tablet):");
        string productType = Console.ReadLine();

        IComponentFactory factory = GetFactory(productType);
        if (factory != null)
        {
            IScreen screen = factory.CreateScreen();
            IProcessor processor = factory.CreateProcessor();
            ICamera camera = factory.CreateCamera();

            Console.WriteLine($"Assembling {productType} with the following components:");
            screen.Display();
            processor.Process();
            camera.Capture();
        }
        else
        {
            Console.WriteLine("Невідомий тип продукту.");
        }
    }

    static IComponentFactory GetFactory(string productType)
    {
        switch (productType.ToLower())
        {
            case "smartphone":
                return new SmartphoneFactory();
            case "laptop":
                return new LaptopFactory();
            case "tablet":
                return new TabletFactory();
            default:
                return null;
        }
    }
}

