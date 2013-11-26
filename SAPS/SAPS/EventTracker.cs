using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class EventTracker
    {
        private static EventTracker _instance;

        public EventTracker Instance
        {
            get
            {
                return _instance;
            }
        }

        public EventTracker()
        {
            _instance = this;
        }
    }
}
