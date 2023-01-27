class CON13{

public CON13(int c):this(){

System.Console.WriteLine(c);

}

public static void Main(){

new CON13("Srilanka",25);

}

public CON13(){

System.Console.WriteLine("default Constructor");

}

public CON13(string s, int y):this(y){

System.Console.WriteLine(s);
System.Console.WriteLine(y);

}

}