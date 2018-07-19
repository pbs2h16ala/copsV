using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copsV.Content.Economy.Dealer
{
    class Backpack
    {
        private int size;
        private Item[] items;

        public Backpack()
        {

        }

        public int Size { get => size; set => size = value; }
        internal Item[] Items { get => items; set => items = value; }

        public void Setup()
        {
            this.size = 25;
            this.items = new Item[Size];
        }

        public void Setup(int size)
        {
            this.size = size;
            this.items = new Item[Size];
        }

        public bool AddItem(Item item)
        {
            List<int> freeItemSlots = this.GetFreeItemSlots();

            if (freeItemSlots.Count > 0)
            {
                int freeSlot = freeItemSlots.ElementAt<int>(0);

                this.items[freeSlot] = item;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddItemAtIndex(Item item, int index)
        {
            if (this.IsItemSlotEmpty(index))
            {
                this.items[index] = item;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveItem(int index)
        {
            this.items[index] = new Item();
            this.items[index].SetupEmptyItem();
        }

        public List<int> GetFreeItemSlots()
        {
            List<int> freeItemSlots = new List<int>();

            for (int i = 0; i < this.items.Length; i++)
            {
                if (this.IsItemSlotEmpty(i))
                {
                    freeItemSlots.Add(i);
                }
            }

            return freeItemSlots;
        }

        public bool IsItemSlotEmpty(int index)
        {
            if (this.items[index].Name == "empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
