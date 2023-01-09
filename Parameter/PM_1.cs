using System;

class PM_1
{
    static void Main(string[] args){
        System.Console.WriteLine("Simple Calculator");
        // getNumbers();
    }

    static void getNumbers(){
        System.Console.WriteLine("1st Number >>");
        string n1 = Console.ReadLine();
        System.Console.WriteLine("2nd Number >>");
        string n2 = Console.ReadLine();
        // int result = getAddition(p,q);
        // System.Console.WriteLine(result);
    }

    static int getAddition(int p, int q){
        return p+q;
    }
}