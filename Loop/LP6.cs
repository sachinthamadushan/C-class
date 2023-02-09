using System;
using System.Security.AccessControl;
class LP6
{
    
    public static void Main(string[] args){
        System.Console.WriteLine("Enter your marks:");
        string input = System.Console.ReadLine();
        Int32 marks = Int32.Parse(input);
        
        if(75 <= marks){
            System.Console.WriteLine("Grade A");
        }else if(65<=marks){
            System.Console.WriteLine("Grade B");
        }else if(55<=marks){
            System.Console.WriteLine("Grade C");
        }else if(40<=marks){
            System.Console.WriteLine("Grade S");
        }else{
            System.Console.WriteLine("Grade W");
        }

    }
}