using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class EventSystem
    {
        private static EventSystem _instance;

        public static EventSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public EventSystem()
        {
            _instance = this;
        }
    }
}
