using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Starship : Subject // this is the RealSubject class
    {
        int shields;
        int hull;
        int power;
        int torpedoCount;
        bool phasers;
        bool sensors;
        bool comms;
        public Starship()
        {
            shields = 100;
            hull = 100;
            power = 100;
            torpedoCount = 10;
            phasers = true;
            sensors = true;
            comms = true;
        }
        public string getShields()
        {
            return shields + "%";
        }

        public string getHull()
        {
            return hull + "%";
        }

        public string getPower()
        {
            return power + "%";
        }

        public string getWeapons()
        {
            return torpedoCount + " torpedoes";
        }

        public string getSensors()
        {
            if (sensors)
            {
                return "active";
            }
            else
            {
                return "being jammed";
            }
        }

        public string getComms()
        {
            if (comms)
            {
                return "functioning";
            }
            else
            {
                return "being jammed";
            }
        }

        public void jamFrequencies()
        {
            sensors = false;
            comms   = false;
        }

        public void detonate()
        {
            if (shields > 0)
            {
                shields -= 50;
            }
            else
            {
                shields = 0;
            }
            if (hull > 29)
            {
                hull -= 30;
            }
            else
            {
                hull = 0;
            }
        }

        public void fireWeapons()
        {
            if (torpedoCount > 0){
                torpedoCount--;
            }
            power -= 5;
        }

        public int hullIntegrity()
        {
            return hull;
        }
        public int torpCount()
        {
            return torpedoCount;
        }
    }
}
