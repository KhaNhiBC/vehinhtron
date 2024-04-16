internal class Program
{
    private static void Main(string[] args)
    {
        Hinhtron mycircle = new Hinhtron(13);
        Console.WriteLine("Dien tich hinh tron la: {0}",mycircle.AreaHinhtron());
        Console.WriteLine("Chu vi hinh tron la: {0}",mycircle.Chuvihinhtron());
    
        Inventory myInventory = new Inventory();
        foreach (var item in myInventory.myitem)
        {
            Console.Write(item.itemname+",");
            
            Console.Write(item.attack+",");
            
            Console.Write(item.health+",");
            Console.WriteLine();
        }

    }
}