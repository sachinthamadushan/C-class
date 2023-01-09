using System;
namespace Cake
{
    class Shop
    {
        static string shopName;
        static string location;
        static void Main(string[] a){
            setDetails();
            System.Console.WriteLine("Welcome to "+shopName);
            requestOrder();
            System.Console.WriteLine("Your order is ready");
        }
        static void setDetails(){
            shopName = "Wasana cake shope ";
            location = "Colombo";
        }
        static void requestOrder(){
            string cakeName  = "Chocolate";
            double price  = 750;
            System.Console.WriteLine(cakeName);
            System.Console.WriteLine(price);
            System.Console.WriteLine("Order has placed");
        }
    }
}