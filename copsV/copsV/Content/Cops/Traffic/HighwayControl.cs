using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
using copsV.Content.General;

namespace copsV.Content.Cops.Traffic
{
    class HighwayControl
    {
        // static locations of highway controls in the world
        public Vector3[] staticControlPositions = { new Vector3(1565.368f, 921.247f, 77.698f), new Vector3(260.074f, 1268.870f, 232.987f) };
        public float[] staticControlHeadings = { 348.00f, 31.00f};

        private bool isInStandby = true;


        public HighwayControl()
        {

        }

        // Setup Methods

        public void SpawnStaticControl(int index)
        {

            // Spawn cop and car, set cop into car
            Vehicle copCar = Spawner.SpawnVehicle(VehicleHash.Police, this.staticControlPositions[index], this.staticControlHeadings[index]);
            Ped cop = Spawner.SpawnPed(PedHash.Cop01SFY, new Vector3( 0, 0, 0), 0.0f);
            cop.SetIntoVehicle(copCar, VehicleSeat.Driver);

            // Set cop behaviour

            // Confirm setup to player
            UI.ShowSubtitle("Simple highway control created..");
        }

        public void SetupSimpleControlNearPlayer()
        {

        }



    }
}
