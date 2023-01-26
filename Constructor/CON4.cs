class CON4{

public static void Main(){

CON4 x = new CON4();
x.m(true,10.65);
x.m(20.5,false);	
}

void m(bool x, double y){
System.Console.WriteLine("Method 01");
}

void m(double y , bool x){
System.Console.WriteLine(y);
System.Console.WriteLine(x);
}
}