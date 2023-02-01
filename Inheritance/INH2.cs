class INH2 {

public int x = 30;

public void m(){
System.Console.WriteLine("Instance Method");
}

}

class INH3 : INH2{

public static void Main(){

INH3 a = new INH3();
System.Console.WriteLine(a.x);
a.m();
}

}