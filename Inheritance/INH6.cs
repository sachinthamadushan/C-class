class INH6{

public INH6(){
System.Console.WriteLine("Super");
}

}

class INH7 : INH6{

public INH7(){
System.Console.WriteLine("Child");
}

public static void Main(){
INH7 c = new INH7();
}

}