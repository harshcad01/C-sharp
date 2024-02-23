using System;

public class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("Lets See What are Courses They have ...");
        Console.WriteLine("We Have 2 Courses avail Here");
        Console.WriteLine("Select The Course You Want : (CAD/AI)");
        string[] course = { "CAD", "AI" };
        string selectedCourse = Console.ReadLine();
        Console.WriteLine();

        if (selectedCourse == "AI")
        {
            Ai a = new Ai();
            a.service();
            a.aibatch();
        }
        else if (selectedCourse == "CAD")
        {
            Cad c = new Cad();
            c.service();
            c.cadbatch();
        }
        else
        {
            Console.WriteLine("Choose Course is Not Available");
        }
    }
}