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

        private bool existsInWorld;
        private bool isInStandby;


        public HighwayControl()
        {

        }

        public void SpawnStaticControls()
        {
            for (int index = 0; index < this.staticControlPositions.Length; index++)
            {
                this.existsInWorld = true;
                this.isInStandby = true;

                // Spawn cop and car, set cop into car
                Vehicle copCar = Spawner.SpawnVehicle(VehicleHash.Policeb, this.staticControlPositions[index], this.staticControlHeadings[index]);
                Ped cop = Spawner.SpawnPed(PedHash.Cop01SMY, new Vector3(0, 0, 0), 0.0f);
                cop.SetIntoVehicle(copCar, VehicleSeat.Driver);
            }

            // Set cop behaviour

            // Confirm setup to player
            UI.ShowSubtitle("Static highway controls created..");
        }

        public void SpawnSpecificStaticControl(int index)
        {
            this.existsInWorld = true;
            this.isInStandby = true;

            Vector3 stbyLocation = this.staticControlPositions[index];

            // Spawn cop and car, set cop into car
            Vehicle copCar = Spawner.SpawnVehicle(VehicleHash.Police, stbyLocation, this.staticControlHeadings[index]);
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
