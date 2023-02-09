
using System;

class CO1
{
    public static void Main(){
        string fn = Console.ReadLine();
        Int32 f = Int32.Parse(fn);
        string o = Console.ReadLine();
        string sn = Console.ReadLine();
        Int32 s = Int32.Parse(sn);
       

        switch(o){
            case "+":
                System.Console.WriteLine(f+s);
                break;
            case "-":
                System.Console.WriteLine(f-s);
                break;
            default:
                System.Console.WriteLine("Invalid");
                break;
        }
        
    }
}