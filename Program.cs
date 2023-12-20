using System;
using Zoology;

Pigeon p = new Pigeon();
Seagull s = new Seagull();
Cat c = new Cat();
Platypus pl = new Platypus();
Dolphin d = new Dolphin();
PaintedDog pd = new PaintedDog();

List<IFlying> birds = new List<IFlying>() { p, s };
Console.WriteLine(birds);

List<IWalking> walkers = new List<IWalking>() { p, s, c, pl, pd };
Console.WriteLine(walkers);

List<ISwimming> swimmers = new List<ISwimming>() { d, s, pl };
Console.WriteLine(swimmers);

namespace Zoology 
{
   public interface IWalking
   {
    void Run();
    void Walk();
   } 
   public interface ISwimming
   {
    int MaximumDepth { get; }
    void Swim();
   }

   public interface IFlying
   {
    void Fly();
   }

   public class Platypus : IWalking, ISwimming
{
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }

    public int MaximumDepth { get; } = 10;

    public void Swim()
    {
        Console.WriteLine("Swim, Swim");
    }
}
public class Pigeon : IWalking, IFlying
{
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }

    public void Fly()
    {
        Console.WriteLine("I'm in the air!");
    }
}
public class Dolphin : ISwimming
{
    public int MaximumDepth { get; } = 1000;

    public void Swim()
    {
        Console.WriteLine("Swim, Swim");
    }
}
public class Cat : IWalking
{
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }
}
    public class PaintedDog : IWalking
{
    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }
}
public class Seagull : IWalking, IFlying, ISwimming
{
    public void Walk()
    {
        Console.WriteLine("Walk around");
    }

    public void Run()
    {
        Console.WriteLine("You can't catch me!");
    }

    public void Fly()
    {
        Console.WriteLine("I'm in the air!");
    }

    public int MaximumDepth { get; } = 10;

    public void Swim()
    {
        Console.WriteLine("Swim, Swim");
    }
}
}