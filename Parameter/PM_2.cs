using System;
class PM_2
{
    static string a = "Sri Lanka";

    public static void m1(){
        string x = PM_3.m1(a);
        System.Console.WriteLine(x);
    }

    static void Main(string[] args){
        m1();
    }
}

class PM_3
{
    static string a = "England";

    public static string m1(String a){
      return PM_3.a;  
    }
}