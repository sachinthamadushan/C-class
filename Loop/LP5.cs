using System;

class LP5
{
    public static void Main(string[] args){
        System.Console.WriteLine("Enter radius :");
        // Int32 r = Int32.Parse(System.Console.ReadLine());
        double r = double.Parse(System.Console.ReadLine());
        const double p = 3.14;
        double area = p*(r*r);
        System.Console.WriteLine("Area = "+area);
    }
}