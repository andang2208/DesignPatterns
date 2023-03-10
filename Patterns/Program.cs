using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.FactoryMethod;
using DesignPatterns.Patterns.State;
using DesignPatterns.Patterns.Transportation;

class Program
{
    static void RunFactoryMethod()
    {
        var factory = new FactoryCreator();

        ITransportation truck = factory.Create(TransportType.Truck);
        Console.WriteLine("License plate:" + truck.GetLicensePlate());
        Console.WriteLine("Load capacity: " + truck.GetLoadCapacity());
        Console.WriteLine("Trip info: " + truck.GetTripInfo());


        Console.WriteLine("\n\n===========================================\n\n");

        ITransportation ship = factory.Create(TransportType.Ship);
        Console.WriteLine("License plate:" + ship.GetLicensePlate());
        Console.WriteLine("Load capacity: " + ship.GetLoadCapacity());
        Console.WriteLine("Trip info: " + ship.GetTripInfo());

        Console.ReadLine();
    }

    static void RunDecorator()
    {
        Console.Title = "DECORATOR DESIGN PATTERN";
        Notifier original = new Notifier();
        SMSDecorator sms = new SMSDecorator(original);
        FacebookDecorator facebook = new FacebookDecorator(original);
        SMSDecorator sms_facebook = new SMSDecorator(facebook);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Original: {original.Send()}");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nEmail & SMS: {sms.Send()}");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nEmail & Facebook: {facebook.Send()}");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nAll apps: {sms_facebook.Send()}");
        Console.ReadKey();
    }

    static void RunState()
    {
        var order = new Order(new DraftState());
        order.GetCurrentState();
        Console.WriteLine("");

        order.ConfirmOrder();
        order.GetCurrentState();
        Console.WriteLine("");

        order.DeliveryOrder();
        order.GetCurrentState();
        Console.WriteLine("");

        order.CancelOrder();
        order.GetCurrentState();

    }

    static void Main(string[] args)
    {
        //RunFactoryMethod();
        //RunDecorator();
        RunState();
    }
}
