class Cake1{

static void Main(string[] args){

string sc = "Sponge Cake";
string sct = "Strawberry topping";
double scp = 2850;
string rvc = "Red Velvate Cake";
string rct = "Butter cream";
double rvp = 3500;
printSC(sc, sct, scp);
printRVC(rvc,rct,rvp);

}

static void printSC(string name,string topping, double price ){
System.Console.WriteLine("Name : "+ name);
System.Console.WriteLine("Topping : "+ topping);
System.Console.WriteLine("Price Rs : "+ price);
}

static void printRVC(string name,string topping, double price ){
System.Console.WriteLine("Name : "+ name);
System.Console.WriteLine("Topping : "+ topping);
System.Console.WriteLine("Price Rs : "+ price);
}

}