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
        a.arithmetic();
        a.switc();
    }
}

class Harsh
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
            Console.WriteLine("loop goes till.."+c);

            c++;
        }
        while(c<50);
    }

    public void arithmetic()
    {
        int x=20;
        int y=10;
        int add=x+y;
        Console.WriteLine("Added value is.."+add);
        int sub=x-y;
        Console.WriteLine("subtracted value is.."+sub);
        int mul =x*y;
        Console.WriteLine("multiplied value is.."+mul);
        int div=x/y;
        Console.WriteLine("divided value is.."+div);
    }

    public void switc()
    {
    Console.WriteLine("Enter firstNumber:");
    string usera = Console.ReadLine();
    int a = int.Parse(usera);

    Console.WriteLine("Enter secondNumber:");
    string userb = Console.ReadLine();
    int b = int.Parse(userb); 

    int c;

    Console.WriteLine("Enter operator (+, -, *, /):");
    string opt = Console.ReadLine();

    switch(opt)
    {
        case "+":
            c = a + b;
            Console.WriteLine("Added value is: " + c);
            break;
        // Add other cases for other operators here

        default:
            Console.WriteLine("Invalid operator entered.");
            break;
    }
    }

}
