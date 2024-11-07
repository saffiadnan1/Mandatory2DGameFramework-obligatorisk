using Mandatory2DGameFramework.model.attack;
using Mandatory2DGameFramework.model.defence;
using Mandatory2DGameFramework.worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mandatory2DGameFramework.model.Cretures
{

    
        public class Creature : ICreature
        {
            private static int _idCounter = 0;
            public int Id { get; private set; }
            public string Name { get; private set; }
            public int HitPoints { get; private set; }
            public int X { get; private set; }
            public int Y { get; private set; }
            public List<AttackItem> AttackItems { get; private set; }
            public List<IDefenceObject> DefenceItems { get; private set; }

            public Creature(string name, int hitPoints, int x, int y)
            {
                Id = ++_idCounter;
                Name = name;
                HitPoints = hitPoints;
                X = x;
                Y = y;
                AttackItems = new List<AttackItem>();
                DefenceItems = new List<IDefenceObject>();
            }

            public void Hit(ICreature target, int damage)
            {
                int totalDamage = damage + AttackItems.Sum(item => item.HitPoint);
                target.ReceiveDamage(totalDamage);
            }

            public void ReceiveDamage(int damage)
            {
                int totalDefence = DefenceItems.Sum(item => item.DefencePoint);
                int actualDamage = Math.Max(0, damage - totalDefence);
                HitPoints -= actualDamage;
            }
        }
}

