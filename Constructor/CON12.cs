class CON12{

public CON12(int c){

System.Console.WriteLine("Para Constructor");
System.Console.WriteLine(c);
}

public static void Main(){

CON12 x = new CON12();
}

public CON12():this(10){

System.Console.WriteLine("default Constructor");

}

}