using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProj.Models
{
    public class Item
    {
        public Item(string itemName, string description, double price, string imageUrl, bool inStock)
        {
            Id = Guid.NewGuid();
            ItemName = itemName ?? throw new ArgumentNullException(nameof(itemName));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            ImageUrl = imageUrl ?? throw new ArgumentNullException(nameof(imageUrl));
            InStock = inStock;
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
    }

}
}
