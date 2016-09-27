using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HeaterShield : AbstractShield // this is the ProductB2 class
    {
        private string shape;
        private string material;
        private bool polished;
        public HeaterShield(string mater){
            shape = "Heater";
            material = mater;
            polished = false;
        }
        public override string getShape()
        {
            return shape;
        }

        public override string getMaterial()
        {
            return material;
        }

        public override void polishShield()
        {
            if (material != "Wooden")
            {
                polished = true;
            }
        }

        public override bool isPolished()
        {
            return polished;
        }
        public override string ToString()
        {
            return material + " " + shape + " Shield";
        }
    }
}
