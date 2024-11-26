using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_World.Game
{
    public static class Input
    {
        public static Action WKeyDown { get; private set; } = () => { };
        public static Action AKeyDown { get; private set; } = () => { };
        public static Action SKeyDown { get; private set; } = () => { };
        public static Action DKeyDown { get; private set; } = () => { };

        public static void OnWKeyDown(Action action) => WKeyDown += action;
        public static void OnAKeyDown(Action action) => AKeyDown += action;
        public static void OnSKeyDown(Action action) => SKeyDown += action;
        public static void OnDKeyDown(Action action) => DKeyDown += action;
    }
}
