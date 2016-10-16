using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Composite : Component // this is the composite class
    {
        private List<Component> content = new List<Component>();
        private bool isCyclic = false;
        public override string getName()
        {
            int count = 0;
            string name = "";
            int i = 0;
            foreach (Component c in content)
            {
                i++;
                if (c.getName() == "Methane")
                {
                    count++;
                }
                else if (c.getName() == "Benzene")
                {
                    name += "" + i + "-" + c.getSubName() + "-";
                }
                else
                {
                    name += "" + i + "-" + c.getSubName() + "-";
                }
            }
            if (isCyclic == true)
            {
                name += "Cyclo";
            }
            switch (count)
            {
                case 0:
                    return "Benzene";
                case 1:
                    name += "Methane";
                    break;
                case 2:
                    name += "Ethane";
                    break;
                case 3:
                    name += "Propane";
                    break;
                case 4:
                    name += "Butane";
                    break;
                case 5:
                    name += "Pentane";
                    break;
                case 6:
                    name += "Hexane";
                    break;
                case 7:
                    name += "Heptane";
                    break;
                case 8:
                    name += "Octane";
                    break;
                case 9:
                    name += "Nonane";
                    break;
                default:
                    name += "error: unsupported structure";
                    break;
            }
            return name;
        }

        public override string getSubName()
        {
            int count = 0;
            string name = "";
            int i = -1;
            foreach (Component c in content)
            {
                i++;
                if (c.getName() == "Methane")
                {
                    count++;
                }
                else if (c.getName() == "Benzene")
                {
                    name += "" + i + "-" + c.getSubName() + "-";
                }
                else
                {
                    name += "" + i + "-" + c.getSubName() + "-";
                }
            }
            switch (count)
            {
                case 0:
                    return "Phenyl";
                case 1:
                    name += "Methyl";
                    break;
                case 2:
                    name += "Ethyl";
                    break;
                case 3:
                    name += "Propyl";
                    break;
                case 4:
                    name += "Butyl";
                    break;
                case 5:
                    name += "Pentyl";
                    break;
                case 6:
                    name += "Hexyl";
                    break;
                case 7:
                    name += "Heptyl";
                    break;
                case 8:
                    name += "Octyl";
                    break;
                case 9:
                    name += "Nonyl";
                    break;
                default:
                    name += "error: unsupported structure";
                    break;
            }
            return name;
        }

        public void setCyclic(bool a)
        {
            isCyclic = a;
        }

        public void addComponent(Component c)
        {
            content.Add(c);
        }

        public void removeComponent(Component c)
        {
            content.Remove(c);
        }

        public int getChildCount()
        {
            return content.Count;
        }

        public Component getChild(int index)
        {
            return content[index];
        }
    }
}
