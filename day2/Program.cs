using System;

public class Bread
{
    public string bre = "I use to eat Bread"; 
}
public class Patty:Bread
{
    public string pat= "And also like to have Patty";
}

class Test
{
    public static void Main(string [] args){
    Patty p= new Patty();

    Console.WriteLine("Harsh :" + p.bre);
    Console.WriteLine("Arav :" +p.pat);
}
}