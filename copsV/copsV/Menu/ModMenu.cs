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
        UIMenu modeMenu_spawner;
        Abilities.CharacterFlash abFlash;
        

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

            this.InitSubMenuSettings();
            menuPool.RefreshIndex();
        }

        private void InitSubMenuSettings()
        {
            // Init submenu
            this.modeMenu_spawner = menuPool.AddSubMenu(modMenu_main, "Spawner");

            // Init Item 1
            this.modeMenu_spawner.AddItem(new UIMenuItem("Spawn highway controls"));

            // Init Item 2
            List<dynamic> staticHighwayControls = new List<dynamic> { 1, 2 };
            this.modeMenu_spawner.AddItem(new UIMenuListItem("Spawn highway control:", staticHighwayControls, 2));

            modeMenu_spawner.OnItemSelect += ItemSelectHandlerSpawner;

            this.modeMenu_spawner.RefreshIndex();
        }
 
        public void ItemSelectHandlerSpawner(UIMenu sender, UIMenuItem selectedItem, int index)
        {
            HighwayControl highwayControl;

            UI.Notify("You have selected: " + selectedItem.Text);

            switch (index)
            {
                case 1:
                    highwayControl = new HighwayControl();
                    highwayControl.SpawnStaticControls();
                    return;

                case 2:
                    int i = Convert.ToInt32(selectedItem.Text);
                    highwayControl = new HighwayControl();
                    highwayControl.SpawnSpecificStaticControl(i);
                    return;

                default: return;
            }

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
                this.ToggleMainMenu();
            }
        }

        public void ToggleMainMenu()
        {
            this.modMenu_main.Visible = !this.modMenu_main.Visible;
        }
    }
}
