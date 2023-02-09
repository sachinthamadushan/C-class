using System.IO;
using System;
using System.Security.AccessControl;
class LP
{
 public static void Main(string[] args){
    
    string r = System.Console.ReadLine();
    string f = fn.Text;
    int rows = Int32.Parse(r);

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

 }   
}