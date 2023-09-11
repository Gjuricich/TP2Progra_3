using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public List <string> Images { get; set; }
        public int ID() { return Id; }


        public Item()
        {
            
        }
        public Item(string artCode, string name, string description, string brand, string category, decimal price)
        {
            ItemCode = ItemCode;
            Name = name;
            Description = description;
            Brand = brand;
            Category = category;
            Price = price;
            Images = new List <string>();

        }

    }
    
}
