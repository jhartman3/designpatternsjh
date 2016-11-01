using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Engineer : Subject // this is the Proxy class
    {
        Starship ship;
        public Engineer()
        {
            ship = new Starship();
        }
        public string getShields()
        {
            return "Our shields are at " + ship.getShields() + ", Captain.";
        }

        public string getHull()
        {
            return "Our hull integrity is at " + ship.getHull() + ", Captain.";
        }

        public string getPower()
        {
            return "Our power level is at " + ship.getPower() + ", Captain.";
        }

        public string getWeapons()
        {
            return "We currently have " + ship.getWeapons() + ", Captain.";
        }

        public string getSensors()
        {
            return "Our sensors are " + ship.getSensors() + ", Captain.";
        }

        public string getComms()
        {
            return "Our communication systems are " + ship.getComms() + ", Captain.";
        }

        public void jamFrequencies()
        {
            ship.jamFrequencies();
        }

        public void detonate()
        {
            ship.detonate();
        }

        public void fireWeapons()
        {
            ship.fireWeapons();
        }

        public int hullIntegrity()
        {
            return ship.hullIntegrity();
        }

        public int torpCount()
        {
            return ship.torpCount();
        }
    }
}
