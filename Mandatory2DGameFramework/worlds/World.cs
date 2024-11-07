using Mandatory2DGameFramework.model.Cretures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory2DGameFramework.worlds
{
    public class World
    {
    private List<Creature> _creatures;

    public World(int width, int height)
    {
        _creatures = new List<Creature>();
        
    }

    public void AddCreature(Creature creature)
    {
        _creatures.Add(creature);
    }

    public Creature GetCreatureByName(string navn)
    {
        return _creatures.FirstOrDefault(c => c.Name == navn);
    }
}
}
