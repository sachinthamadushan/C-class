class INH4
{
    public INH4():this(70){
        System.Console.WriteLine("Super constructor");
    }

    public INH4(int x){
        System.Console.WriteLine("Super int constructor = "+x);
    }
}

class INH5:INH4
{
    public INH5(){
        System.Console.WriteLine("Child constructor");
    }

    public static void Main(){
        INH5 x = new INH5();
    }
}