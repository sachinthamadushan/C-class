class DT10
{
    int x;
    uint r;
    string y;
    double q;
    float f;
    sbyte sb;
    byte b;
    char c;
    bool bo;

    public static void Main(){
        DT10 d = new DT10();
        System.Console.WriteLine($"int {d.x}");
        System.Console.WriteLine($"uint {d.r}");
        System.Console.WriteLine($"string {d.y}");
        System.Console.WriteLine($"double {d.q}");
        System.Console.WriteLine($"float {d.f}");
        System.Console.WriteLine($"sbyte {d.sb}");
        System.Console.WriteLine($"byte {d.b}");
        System.Console.WriteLine($"char {d.c}");
        System.Console.WriteLine($"bool {d.bo}");
        
    }
}