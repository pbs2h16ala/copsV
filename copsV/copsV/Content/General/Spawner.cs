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
        public static void SpawnPed(PedHash pedToSpawn, Vector3 posToSpawn)
        {
            Model model_ped = new Model(pedToSpawn);
            Ped ped = World.CreatePed(model_ped, posToSpawn, 0.0f);
        }

        public static void SpawnVehicle(VehicleHash vehicleToSpawn, Vector3 posToSpawn)
        {
            Model model_car = new Model(vehicleToSpawn);
            Ped ped = World.CreatePed(model_car, posToSpawn, 0.0f);
        }
    }
}
