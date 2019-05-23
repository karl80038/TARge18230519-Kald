using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class SingleRandom:Random
    {
        static SingleRandom _Instance;
        public static SingleRandom Instance {
            get {
                if(_Instance == null)
                {
                    _Instance = new SingleRandom();
                }
                return _Instance;
            }

        }
        private SingleRandom() { }
    }
}
      
