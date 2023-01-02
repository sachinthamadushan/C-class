namespace Apple
{
    class Iphone12
    {
        static string model;
        static double price;
        static string camera;
        
        static void Main(string[] args){
            model = "iPhone 14 Plus";
            camera = "Mega pixel 36";
            price = 120000;
            changePrice(15000);
            System.Console.WriteLine(model);
        }

        static void checkCamera(string camera){
            camera = "Mega pixel 48";
            System.Console.WriteLine(camera);
        }

        static void changePrice(double price){
            price = 180000.0;
            System.Console.WriteLine(price);
            checkCamera("Mega pixel 24");
        }
    }
}