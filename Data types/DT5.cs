class DT5
{
    public static void Main(){
         int x = 10, y = 20, q = 90;
        DT5 s = new DT5();
        s.m2(x+y);
    }

    static void m1(int y){
        System.Console.WriteLine(y);
    }

    void m2(int a){
        m1(a);
    }
}

