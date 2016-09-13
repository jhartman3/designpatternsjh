using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadePattern
{
    public partial class Form1 : Form // this is the facade class
    {
        LightSystem   lights;
        AirSystem     air;
        MachineSystem machine;
        int factoryState = 0;
        public Form1()
        {
            InitializeComponent();
            lights  = new LightSystem();
            air     = new AirSystem();
            machine = new MachineSystem();
        }

        // updates the visual display of the factory
        public void updateFactory()
        {
            if (lights.getLightState(0))
            {
                pnl_FactoryFloor.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                pnl_FactoryFloor.BackColor = System.Drawing.Color.Gray;
            }
            if (lights.getLightState(1))
            {
                pnl_Warehouse.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                pnl_Warehouse.BackColor = System.Drawing.Color.Gray;
            }
            if (lights.getLightState(2))
            {
                pnl_Garage.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                pnl_Garage.BackColor = System.Drawing.Color.Gray;
            }
            if (lights.getLightState(3))
            {
                pnl_Office1.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                pnl_Office1.BackColor = System.Drawing.Color.Gray;
            }
            if (lights.getLightState(4))
            {
                pnl_Office2.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                pnl_Office2.BackColor = System.Drawing.Color.Gray;
            }
            if (air.getCoolState(0))
            {
                pnl_AC1.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            }
            else
            {
                pnl_AC1.BackColor = System.Drawing.Color.Navy;
            }
            if (air.getCoolState(1))
            {
                pnl_AC2.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            }
            else
            {
                pnl_AC2.BackColor = System.Drawing.Color.Navy;
            }
            if (air.getCoolState(2))
            {
                pnl_AC3.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            }
            else
            {
                pnl_AC3.BackColor = System.Drawing.Color.Navy;
            }
            if (air.getCoolState(3))
            {
                pnl_AC4.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            }
            else
            {
                pnl_AC4.BackColor = System.Drawing.Color.Navy;
            }
            if (air.getFanState(0))
            {
                pnl_Fan1.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                pnl_Fan1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            if (air.getFanState(1))
            {
                pnl_Fan2.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                pnl_Fan2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            if (air.getFanState(2))
            {
                pnl_Fan3.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                pnl_Fan3.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            if (air.getFanState(3))
            {
                pnl_Fan4.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                pnl_Fan4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            if (machine.getMachineState())
            {
                pnl_machine1.BackColor = System.Drawing.Color.Lime;
                pnl_machine2.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                pnl_machine1.BackColor = System.Drawing.Color.Red;
                pnl_machine2.BackColor = System.Drawing.Color.Red;
            }
        }

        // sets the factory up based on the chosen mode
        public void setFactory(int option)
        {
            if (option == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    lights.setLightState(i, true);
                }
                for (int j = 0; j < 4; j++)
                {
                    air.setCoolState(j, true);
                    air.setFanState(j, true);
                }
                machine.setMachineState(true);
            }
            else if (option == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    lights.setLightState(i, false);
                }
                for (int j = 0; j < 4; j++)
                {
                    air.setCoolState(j, false);
                    air.setFanState(j, false);
                }
                machine.setMachineState(true);
                lights.setLightState(0, true);
                lights.setLightState(3, true);
                air.setCoolState(0, true);
                air.setCoolState(1, true);
                air.setFanState(0, true);
                air.setFanState(1, true);
                air.setFanState(2, true);
            }
            else if (option == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    lights.setLightState(i, false);
                }
                for (int j = 0; j < 4; j++)
                {
                    air.setCoolState(j, false);
                    air.setFanState(j, false);
                }
                machine.setMachineState(false);
                lights.setLightState(4, true);
                air.setFanState(3, true);
            }
            else if (option == 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    lights.setLightState(i, false);
                }
                for (int j = 0; j < 4; j++)
                {
                    air.setCoolState(j, false);
                    air.setFanState(j, false);
                }
                machine.setMachineState(false);
                lights.setLightState(1, true);
                lights.setLightState(2, true);
                lights.setLightState(4, true);
                air.setCoolState(2, true);
                air.setCoolState(3, true);
                air.setFanState(3, true);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    lights.setLightState(i, false);
                }
                for (int j = 0; j < 4; j++)
                {
                    air.setCoolState(j, false);
                    air.setFanState(j, false);
                }
                machine.setMachineState(false);
            }
        }

        private void btn_Facade_Click(object sender, EventArgs e)
        {
            // this is the facade
            // get the index of the chosen option; if none, then return
            factoryState = cmb_Mode.SelectedIndex;
            if (factoryState == -1) return;
            setFactory(factoryState);
            updateFactory();
        }
    }
}
