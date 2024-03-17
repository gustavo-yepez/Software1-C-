using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAppGustavoYepez
{
    public class Inhouse : Part
    {
        private int machID;
        public int MachineID { get; set; }
        public Inhouse() { }
        public Inhouse(int partID, string name, int inventory, decimal price, int max, int min, string text)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public Inhouse(int partID, string name, int inventory, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machID;
        }

    }
}

