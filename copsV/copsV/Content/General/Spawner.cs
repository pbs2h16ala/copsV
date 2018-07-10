using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace copsV.Content.General
{
    class Spawner
    {
        public static Ped SpawnPed(PedHash pedToSpawn, Vector3 posToSpawn, float heading)
        {
            Model model_ped = new Model(pedToSpawn);
            Ped ped = World.CreatePed(model_ped, posToSpawn, heading);

            return ped;
        }

        public static Vehicle SpawnVehicle(VehicleHash vehicleToSpawn, Vector3 posToSpawn, float heading)
        {
            Model model_vehicle = new Model(vehicleToSpawn);
            Vehicle vehicle = World.CreateVehicle(model_vehicle, posToSpawn, heading);

            return vehicle;
        }
    }
}
