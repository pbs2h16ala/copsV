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
using copsV.Content.Economy.Dealer;

namespace copsV.Menu
{
    class ModMenu
    {
        MenuPool menuPool;
        UIMenu modMenu_main;
        UIMenu modMenu_spawner;
        UIMenu modMenu_dealer;

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
            this.modMenu_main.RefreshIndex();

            this.InitSubMenuSpawner();
            menuPool.RefreshIndex();
        }

        private void InitSubMenuSpawner()
        {
            // Init submenu
            this.modMenu_spawner = menuPool.AddSubMenu(modMenu_main, "Spawner");

            // Init Item 1
            this.modMenu_spawner.AddItem(new UIMenuItem("Spawn highway controls"));

            // Init Item 2
            List<dynamic> staticHighwayControls = new List<dynamic> { 1, 2 };
            this.modMenu_spawner.AddItem(new UIMenuListItem("Spawn highway control:", staticHighwayControls, 2));

            modMenu_spawner.OnItemSelect += ItemSelectHandler;

            this.modMenu_spawner.RefreshIndex();
        }

        private void InitSubMenuDealer()
        {
            // Init submenu
            this.modMenu_dealer = menuPool.AddSubMenu(modMenu_main, "Dealer");

            // Init Item 1
            this.modMenu_dealer.AddItem(new UIMenuItem("Rank: " + Dealer.dealer.GetDealerRank()));

            // Init Item 2
            this.modMenu_dealer.AddItem(new UIMenuItem("Reputation: " + Dealer.dealer.GetCustomerReputation()));

            // Init Item 3
            List<dynamic> backpack = Dealer.dealer.Backpack.Items;
            this.modMenu_dealer.AddItem(new UIMenuListItem("Backpack:", backpack, Dealer.dealer.Backpack.Items.Count ));

            modMenu_dealer.OnItemSelect += ItemSelectHandler;

            this.modMenu_dealer.RefreshIndex();
        }

        public void ItemSelectHandler(UIMenu sender, UIMenuItem selectedItem, int index)
        {
            UI.Notify("You have selected: ~b~" + selectedItem.Text);

            UI.ShowSubtitle("Index: " + index);
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
