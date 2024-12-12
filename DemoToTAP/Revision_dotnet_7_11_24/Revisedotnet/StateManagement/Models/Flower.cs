using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StateManagement.Models
{
    [Serializable]
    public class Flower
    {
        public int Id { get; set; }
        [DisplayName("Item Name")]
        public string Name { get; set; }

        [DisplayName("Sale Price")]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        [DisplayName("Unit Price")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit
        {
            get
            {
                return (SalePrice * Quantity) - (UnitPrice * Quantity);
                    
                   
            }
        }
    }

}
