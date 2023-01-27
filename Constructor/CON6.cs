class CON6
{
    private int _x;

    public CON6() : this(15){
        _x = 50;
        System.Console.WriteLine(_x);
    }

    public CON6(int y){
        _x = y;
        System.Console.WriteLine(_x);
    }

    static void Main(){
        CON6 c = new CON6();
    }

}