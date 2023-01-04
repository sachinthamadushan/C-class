using System;
namespace Cal
{
    class SC
    {
        static void Main(string[] a){
            System.Console.WriteLine("Enter 1st number >>");
            string fn = System.Console.ReadLine();
            int x  = int.Parse(fn);
            System.Console.WriteLine("Enter 1st number >>");
            string sn = System.Console.ReadLine();
            int y  = int.Parse(sn);
            int tot = x+y;
            System.Console.WriteLine("Result = "+tot);
        }
    }
}