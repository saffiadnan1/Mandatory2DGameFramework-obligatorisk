using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.model.Cretures
{
    public interface ICreature
    {
            int Id { get; }
            string Name { get; }
            int HitPoints { get; }
            int X { get; }
            int Y { get; }
            void Hit(ICreature target, int damage);
            void ReceiveDamage(int damage);
        
    }
}
