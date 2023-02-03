class INH2 {

public void m(){
System.Console.WriteLine("Super Instance Method");
}

}

class INH3 : INH2{

public static void Main(){

INH3 a = new INH3();
a.m();
}

public void m(){
System.Console.WriteLine("Child Instance Method"); 
}

}