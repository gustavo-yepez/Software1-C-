using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAppGustavoYepez
{
    public class OutSourced : Part
    {
        private string compName;
        public string CompName { get; set; }
        public OutSourced() { }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public OutSourced(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}
