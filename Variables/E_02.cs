namespace Apple
{
    class Iphone13
    {
        static string model;
        static double price;
        
        static void Main(string[] args){
            System.Console.WriteLine("Welcome to factory");
            System.Console.WriteLine(model);
            System.Console.WriteLine(price);
            model = "iPhone 14 Plus";
            price = 120000;
            System.Console.WriteLine(model);
            System.Console.WriteLine(price);

        }
    }
}