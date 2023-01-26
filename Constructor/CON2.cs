class CON2
{
    static void Main(){
    CON2 x  = new CON2();
    x.m();
    }

    void m(int x){
    System.Console.WriteLine("Method 01");
    }

    void m(){
    System.Console.WriteLine("Method 02");
    }
}