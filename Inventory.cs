public class Inventory
{
    public List<Item> myitem = new List<Item>();
    public Inventory()
    {

        Item item1 = new Item();
        item1.itemname = "Sword";
        item1.attack = 10;
        item1.health = 60;
        myitem.Add(item1);

        Item item2 = new Item();
        item2.itemname = "Bow";
        item2.attack = 15;
        item2.health = 70;
        myitem.Add(item2);

        Item item3 = new Item();
        item3.itemname = "Shield";
        item3.attack = 5;
        item3.health = 80;
        myitem.Add(item3);
    }
}