using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_
{
    internal class Dots : CoordinateSystem
    {
        private string name;
        private string color;

        public string Name { get; set; }
        public string Color { get; set; }

        public Dots() : base() { }
        public Dots(Double x, Double y, Double z) : base(x, y, z) { }
        public Dots(Double x, Double y, Double z, string name) : base(x, y, z) 
        { this.name = name; }

        public Dots(Double x, Double y, Double z, string name, string color) : base(x, y, z)
        {
            this.name = name;
            this.color = color;
        
        }

        public override string Print()
        {
            return $" {base.Print()}, Имя - {name}, Цвет - {color}.";
        }

    }
}
