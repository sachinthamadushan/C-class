namespace RTC5
{
    class PizzaHut
    {
      
        static void Main(string[] args){
            string name = "Cheese pizza";
            double price = 1500.0;
            makeOrder(name,price);
        }

        static void makeOrder(string p, double d){
	
	    System.Console.WriteLine(p);
        System.Console.WriteLine(d);
        }  
        
    }

   
}