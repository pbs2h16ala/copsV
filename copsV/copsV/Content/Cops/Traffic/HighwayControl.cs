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
        private Vector3 pos_stby;                        //Standby location of police control in the World
        private Vector3 pos_vehicleStandby;              //position of officer vehicle

        private Ped cop;
        private Vehicle copCar;

        public Ped Cops { get => cop; set => cop = value; }
        public Vehicle CopCar { get => copCar; set => copCar = value; }

       

        public HighwayControl()
        {

        }

        // Setup Methods

        public void SetupSimpleControl()
        {
            // Get player position + offset
            this.pos_stby = Game.Player.Character.Position;
            this.pos_stby.X = this.pos_stby.Y + 10;

            // Spawn cop and car, set cop into car
            Vehicle copCar = Spawner.SpawnVehicle(VehicleHash.Police, this.pos_stby);
            Ped cop = Spawner.SpawnPed(PedHash.Cop01SFY, this.pos_stby);
            cop.SetIntoVehicle(copCar, VehicleSeat.Driver);

            // Set cop behaviour


            UI.ShowSubtitle("SetupSimpleControl - Performed");
        }

        public void SetupSimpleControlNearPlayer()
        {

        }



    }
}
