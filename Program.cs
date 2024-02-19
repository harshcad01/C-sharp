using System;

class Demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello bee");
        
        //Now we create a object from class Harsh
        Harsh a = new Harsh(); // here Harsh in a object and a is a object name
        a.cal(); // here we use (. dot) for call the method from object a. 
        a.mood();
    }
}

public class Harsh
{
    int a = 10;
    int b = 30;
    int c;

    public Harsh()
    {
        c = a + b; // Calculate 'c' during object initialization
        
    }

    public void cal()
    {
        Console.WriteLine(c);
        if (c == 30)
        {
            Console.WriteLine("Yes It is");
        }
        else
        {
            Console.WriteLine("No its not"); // Corrected typo here
        }
    }

    public void mood()
    {
        do
        {
            Console.WriteLine(c);
            c++;
        }
        while(c<50);
    }
}
