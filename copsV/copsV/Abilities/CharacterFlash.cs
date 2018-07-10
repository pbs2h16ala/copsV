using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace copsV.Abilities
{
    class CharacterFlash
    {
        private const float FLASH_DISTANCE_MULT = 20.00f;
        private const float MOVING_SPEED_MULT = 15000.00f;

        public void PerformAbilityAction()
        {

            Ped hero = Game.Player.Character;

            Vector3 heroPos = hero.Position;
            Vector3 cameraDirection = GameplayCamera.Direction;

            hero.Rotation = GameplayCamera.Rotation;

            float targetX = heroPos.X + cameraDirection.X * FLASH_DISTANCE_MULT;
            float targetY = heroPos.Y + cameraDirection.Y * FLASH_DISTANCE_MULT;
            float targetZ = heroPos.Z + cameraDirection.Z * FLASH_DISTANCE_MULT;

            Vector3 targetPosition = new Vector3(targetX, targetY, targetZ);

            hero.Position = targetPosition;      
        }


        //public override void PerformAbilityAction()
        //{

        //    Ped hero = Game.Player.Character;

        //    Vector3 heroPos = hero.Position;
        //    Vector3 cameraDirection = GameplayCamera.Direction;

        //    hero.Rotation = cameraDirection;

        //    float targetX = heroPos.X + cameraDirection.X * FLASH_DISTANCE;
        //    float targetY = heroPos.Y + cameraDirection.Y * FLASH_DISTANCE;
        //    float targetZ = heroPos.Z + cameraDirection.Z * FLASH_DISTANCE;

        //    hero.Position = new Vector3(targetX, targetY, targetZ);

        //    UI.ShowSubtitle("action BatFlash performed");
        //}
    }
}
