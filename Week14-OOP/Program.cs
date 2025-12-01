Dog goodBoy = new Dog("Good boy");
Console.WriteLine($"Name: {goodBoy.Name}, Level of happiness: {goodBoy.LevelOfHappiness}");

while(goodBoy.LevelOfHappiness < 5)
{
    goodBoy.Bark();
}

goodBoy.Wag();

class Dog
{
    public string Name;
    public int LevelOfHappiness;

    public Dog(string name)
    {
        Name = name;
        LevelOfHappiness = 0;
        Console.WriteLine($"{Name} is your friend now.");
    }

    public void Bark()
    {
        LevelOfHappiness++;
        Console.WriteLine("Woof-woof");
    }

    public void Wag()
    {
        Console.WriteLine($"{Name} starts wagging its tail.");
        Console.WriteLine("Woosh-whosh");
    }
}
