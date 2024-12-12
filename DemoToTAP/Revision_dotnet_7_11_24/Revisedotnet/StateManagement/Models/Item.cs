namespace StateManagement.Models
{
    [Serializable]
    public class Item
    {
        public Flower theFlower { get; set; }
        
        public int Quantity { get; set; }
        public Item() { }
    }
}
