using CoffeeMasterShop_DataAccess.Enums;

namespace CoffeeMasterShop_DataAccess.Models
{
    public class CoffeeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CoffeeBeans { get; set; }

        public SizeCup SizeCup { get; set; }

        public bool ToGoOrNot { get; set; }

        public bool WithDelivery { get; set; }
    }
}
