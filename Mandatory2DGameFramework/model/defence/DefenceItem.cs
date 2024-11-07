using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.defence
{
    public class DefenceObject : IDefenceObject
    {
        public string Name { get; private set; }
        public int DefencePoint { get; private set; }
        public int Weight { get; private set; }
        public int Durability { get; private set; }
        public bool IsEquipped { get; private set; }



        public DefenceObject(string name, int defencePoint, int weight, int durability, bool isEquipped)
        {
            Name = name;
            DefencePoint = defencePoint;
            Weight = weight;
            Durability = durability;
            IsEquipped = isEquipped;
        }
    }
}

