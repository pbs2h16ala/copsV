using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
using NativeUI;
using copsV.Content.Cops.Traffic;

namespace copsV.Menu
{
    class ModMenu
    {
        MenuPool menuPool;
        UIMenu modMenu_main;
        UIMenu modMenu_settings;
        Abilities.CharacterFlash abFlash;
        HighwayControl highwayControl;
        

        public ModMenu()
        {
            this.InitModMenu();
            abFlash = new Abilities.CharacterFlash();
        }

        private void InitModMenu()
        {
            this.menuPool = new MenuPool();

            this.modMenu_main = new UIMenu("CopsV", "complete Overhaul");
            this.menuPool.Add(modMenu_main);

            this.modMenu_settings = menuPool.AddSubMenu(modMenu_main, "Settings");
        }


        public void OnTick()
        {
            this.ProcessMenusIfNeeded();
        }

        private void ProcessMenusIfNeeded()
        {
            if (this.modMenu_main.Visible)
            {
                this.menuPool.ProcessMenus();
            }
        }

        public void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                abFlash.PerformAbilityAction();
            }

            if (e.KeyCode == Keys.K)
            {
                this.highwayControl = new HighwayControl();
                this.highwayControl.SpawnStaticControls();
            }
        }

        public void ToggleMainMenu()
        {
            this.modMenu_main.Visible = !this.modMenu_main.Visible;
        }
    }
}
