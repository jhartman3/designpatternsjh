using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LongSword : AbstractSword // this is the ProductA1 class
    {
        private int bladeLength;
        private string material;
        private bool sharpened;
        public LongSword(string mater)
        {
            bladeLength = 42;
            material = mater;
            sharpened = false;
        }
        public override int getLength()
        {
            return bladeLength;
        }

        public override string getMaterial()
        {
            return material;
        }

        public override void sharpenBlade()
        {
            sharpened = true;
        }

        public override bool isSharp()
        {
            return sharpened;
        }
        public override string ToString()
        {
            return material + " Longsword";
        }
    }
}
