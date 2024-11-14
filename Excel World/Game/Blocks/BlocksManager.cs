using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game.Blocks
{
    public static class BlocksManager
    {
        public static Block[] Blocks = new Block[1024];

        public static void Init()
        {
            Assembly s = typeof(Block).Assembly;
            foreach (Type type in s.GetTypes()) 
            {
                if (typeof(Block).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    Block block = Activator.CreateInstance(type) as Block;
                    Blocks[(int)type.GetTypeInfo().GetDeclaredField("Index").GetValue(block)] = block;
                }
            }
        }
    }
}
