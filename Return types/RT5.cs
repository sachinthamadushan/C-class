using System;
class RT5
{
    static string c  = "India";

    static void Main(string[] args){
       string s  = m1(c);  
       c = m2();
       System.Console.WriteLine(c);
       System.Console.WriteLine(s);
    }

    static string m1(string s){
        s = m2();
        return s;
    }

    static string m2(){
        return "Sri Lanka";
    }
}