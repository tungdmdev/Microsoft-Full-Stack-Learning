public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

    public void Eat()
    {
        Console.WriteLine("Some generic animal food");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Kibble");
    }

    public override void MakeSound(){
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Tuna");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        myDog.MakeSound(); // Should print "Bark"
        myCat.MakeSound(); // Should print "Meow"

        myDog.Eat(); // Should print "Kibble"
        myCat.Eat(); // Should print "Tuna"
        
        List<Animal> animals = new List<Animal>();
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }

    }
}