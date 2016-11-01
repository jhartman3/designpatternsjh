using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface Subject // this is the subject interface
    {
        string getShields();
        string getHull();
        string getPower();
        string getWeapons();
        string getSensors();
        string getComms();
        void jamFrequencies(); // this is a doOperation method
        void detonate();       // this is a doOperation method
        void fireWeapons();    // this is a doOperation method
        int hullIntegrity();
        int torpCount();
    }
}
