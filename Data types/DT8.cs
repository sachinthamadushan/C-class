class DT8
{
    public static void Main(){
        sbyte sb = -30;
        ushort us = 1030;
        uint ui = 100u;
        float fl = 10.2f;
        long l = 45755452222222l;
        ulong ul = 45755452222222ul;
        double d = 11452222.555d;
        decimal mon = 1000.15m;
        
        System.Console.WriteLine(sb);
        System.Console.WriteLine(sb.GetType());
        System.Console.WriteLine(us);
        System.Console.WriteLine(us.GetType());
        System.Console.WriteLine(ui);
        System.Console.WriteLine(ui.GetType());
        System.Console.WriteLine(fl);
        System.Console.WriteLine(fl.GetType());
        System.Console.WriteLine(l);
        System.Console.WriteLine(l.GetType());
        System.Console.WriteLine(ul);
        System.Console.WriteLine(ul.GetType());
        System.Console.WriteLine(d);
        System.Console.WriteLine(d.GetType());
        System.Console.WriteLine(mon);
        System.Console.WriteLine(mon.GetType());
    }
}

