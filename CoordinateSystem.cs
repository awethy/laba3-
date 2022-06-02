using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_
{
    internal class CoordinateSystem
    {
        private Double x;
        private Double y;
        private Double z;

        public Double X { get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }

        public CoordinateSystem() { }
        public CoordinateSystem(Double x) { this.x = x; }
        public CoordinateSystem(Double x, Double y) { this.x = x; this.y = y; }
        public CoordinateSystem(Double x, Double y, Double z) { this.x = x; this.y = y; this.z = z; }

        public virtual string Print()
        {
            return $"X - {this.x}, Y - {this.y}, Z - {this.z}";
        }


    }
}
