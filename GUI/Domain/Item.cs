using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        public string ArtCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Marc { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }


        public Item()
        {
        }
        public Item(string artCode, string name, string description, string marc, string category, decimal price)
        {
            ArtCode = artCode;
            Name = name;
            Description = description;
            Marc = marc;
            Category = category;
            Price = price;

        }

    }
    
}
