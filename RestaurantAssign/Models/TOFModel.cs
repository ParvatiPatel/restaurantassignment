namespace RestaurantAssign.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TOFModel : DbContext
    {
        public TOFModel()
            : base("name=TOFConnection")
        {
        }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

      
    }
}
