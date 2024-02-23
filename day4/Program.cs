using System;
protected class Heroine
{
    public string Her()
    {
        return "Super Women Is there to save You!";
    }

    public string Him()
    {
        return "I am a Super Man! I can do anything";
    }
}


public class Super : Heroine
{
    public void Sus()
    {
        Console.WriteLine("Ok I am Done with It");
    }

}

class SuperHero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Who is the hero today? ");
        Super c = new Super();

        c.Sus();
        c.Her();
        c.Him();


    }
}

SuperHero natrayan = new ();