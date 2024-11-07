using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.attack
{
    public class AttackItem
    {
        public string Navn { get; private set; }
        public int HitPoint { get; private set; }
        public int Weight { get; private set; }
        public int Range { get; private set; }
        public int Durability { get; private set; }
        public bool IsEquipped { get; private set; }

        public AttackItem(string navn, int hitPoint, int weight, int range, int durability, bool isEquipped)
        {
            Navn = navn;
            HitPoint = hitPoint;
            Weight = weight;
            Range = range;
            Durability = durability;
            IsEquipped = isEquipped;
        }
    }
}
