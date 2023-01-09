namespace EV2{

    class E_7 {

        static void Main(string[] arg){
            m2();
            m1();
            m3();
        }

        public static void m2(){
        int x  = 25;
        System.Console.WriteLine("Method 2");
        System.Console.WriteLine(x);
        }

        public static void m1(){
        System.Console.WriteLine("Method 1");
        string y = "Hello";
        System.Console.WriteLine(y);
        }


        public static void m3(){
        System.Console.WriteLine("Method 3");
        }
    }
}