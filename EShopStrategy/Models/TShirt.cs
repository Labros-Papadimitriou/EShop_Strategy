using EShopStrategy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopStrategy.Models
{
    public class TShirt
    {
        public Color Color;
        public Fabric Fabric;
        public Size Size;
        public decimal Price { get; set; }

        public TShirt(Color color, Fabric fabric, Size size)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

    }
}
