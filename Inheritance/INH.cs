using System.Runtime.CompilerServices;

class INH
{
    public static void Main(string[] args){
        Cake34 butter = new Butter();
        butter.Name = "Butter";
        butter.Topping = "Chocolate";
        butter.Price = 5500;
        System.Console.WriteLine(butter.GetCake());
    }
}

class Cake34 {

    public string Name { get; set; }
    public string Topping { get; set; }
    public double Price { get; set; }
    public string GetCake() => $"{Name} {Topping} Cake\n Rs:{Price}";
    
}

class Butter:Cake34{

}