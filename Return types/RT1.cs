using System;

namespace AppleRT1
{
    class RT1
    {
        static void Main(string[] args){
            int x = makeCamera();
            string y = getModel();
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
        }

        static int makeCamera(){
            return 10;
        }

        static String getModel(){
            return "14 Pro Max";
        }
        
    }
}