namespace Cake2
{
    class Shop2
    {
        static void Main(string[] a){
            System.Console.WriteLine("Welcome to Wasana cake");
            System.Console.WriteLine("Please enter your cake name");
            string cn =  System.Console.ReadLine();
            System.Console.WriteLine("Please enter weight");
            string weight =  System.Console.ReadLine();
            System.Console.WriteLine("Please enter your name");
            string name =  System.Console.ReadLine();
            System.Console.WriteLine("Order placed for "+name);
            System.Console.WriteLine(cn+" "+weight);
            System.Console.WriteLine("Your order is ready");
        }
    }
}