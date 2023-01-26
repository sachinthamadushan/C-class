class CON3{

public static void Main(){

CON3 x = new CON3();
x.m(true,10.65);	
}

void m(int x){
System.Console.WriteLine("Method 01");
}

void m(bool x , double a){
System.Console.WriteLine(a);
System.Console.WriteLine(x);

}
}