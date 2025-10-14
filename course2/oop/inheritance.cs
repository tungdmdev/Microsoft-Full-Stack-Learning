// class based
public class Pool
{
    public int chlorineLevel;
    public int waterLevel;

    public Pool(int chlorine, int waterlevel)
    {
        chlorineLevel = chlorine;
        waterLevel = waterlevel;
    }
    public void PoolInfor()
    {
        Console.WriteLine($"Pool: {chlorineLevel} {waterLevel}");
    }
}

// Derived class
public class Spa : Pool
{
    public int heatLevel;
    public Spa(int chlorine, int waterlevel, int heatlevel)
    {
        chlorineLevel = chlorine;
        waterLevel = waterlevel;
        heatLevel = heatlevel;
    }
    public void PoolInfo()
    {
        Console.WriteLine($"Pool: {chlorineLevel} {waterLevel} {heatLevel}");
    }
}