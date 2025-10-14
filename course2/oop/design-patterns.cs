// Singleton pattern
public class Database
{
    private static Database _instance;
    private Database()
    {
        Console.WriteLine("Database connection established.");
    }
    public static Database GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Database();
        }
        return _instance;
    }
}

// Factory Pattern Example: Interface
public interface INotification
{
    void Send(string message);
}
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}
public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class NotificationFactory
{
    public INotification CreateNotification(string channel)
    {
        if (channel == "Email")
        {
            return new EmailNotification();
        }
        else if (channel == "SMS")
        {
            return new SMSNotification();
        }
    }
}

// Observer Pattern Example: Subject Class
public interface IObserver
{
    void Update(float temperature);
}
public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    RemoveObserver(IObserver observer)
    {
        observvers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}

// Observer Pattern Example: Derived Classes
public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone display: Temperature updated to " + temperature + " degrees.");
    }
}
public class DesktopDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Desktop display: Temperature update to " + temperature + " degrees.");
    }
}

// Observer Pattern Example: Instances
public class Program
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        PhoneDisplay phoneDisplay = new PhoneDisplay();
        DesktopDisplay desktopDisplay = new DesktopDisplay();

        weatherStation.RegisterObserver(phoneDisplay);
        weatherStation.RegisterObserver(desktopDisplay);

        weatherStation.SetTemperature(25.0f);
    }
}