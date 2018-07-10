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

namespace copsV
{
    class AppDelegator : Script
    {
        private bool isModActive;
        private Menu.ModMenu modMenu;

        public AppDelegator()
        {
            Tick += OnTick;
            KeyDown += OnKeyDown;

            this.isModActive = false;
            this.modMenu = new Menu.ModMenu();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (!this.isModActive)
            {
                return;
            }

            this.modMenu.OnTick();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                this.ToggleMod();
            }

            if (this.isModActive)
            {
                this.modMenu.OnKeyDown(e);

            }
        }

        private void ToggleMod()
        {
            if (this.isModActive)
            {
                this.isModActive = false;
                UI.ShowSubtitle("copsV - disabled", 3);
            }
            else
            {
                this.isModActive = true;
                UI.ShowSubtitle("copsV - enabled", 3);
            }
        }
    }
}
