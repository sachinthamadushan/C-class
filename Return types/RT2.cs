namespace RTC3
{
    class RT3
    {
        static int x = 10;

        static void Main(string[] args){
            System.Console.WriteLine(x);
            System.Console.WriteLine(RT2_1.x);
            x = RT2_1.m1();
            System.Console.WriteLine(x);
        }
        
    }

    class RT2_1{

        public static int x = 20;

        public static int m1(){
            return x;
        }
    }
}