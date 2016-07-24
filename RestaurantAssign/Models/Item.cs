using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantAssign.Models
{
    public class Item
    {
        public Item()
        {

        }

        public virtual int ItemId { get; set; }
        public virtual int MenuId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual double Price { get; set; }
        public virtual string OriginalImageUrl { get; set; }
        public virtual string ThumbImageUrl { get; set; }
        public virtual Menu Menu { get; set; }
    }
}