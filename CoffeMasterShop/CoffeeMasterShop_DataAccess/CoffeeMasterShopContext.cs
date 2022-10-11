using Microsoft.EntityFrameworkCore;

namespace CoffeeMasterShop_DataAccess
{
    public class CoffeeMasterShopContext : DbContext
    {
        public CoffeeMasterShopContext(DbContextOptions<CoffeeMasterShopContext> options) : base(options) { }
    }
}
