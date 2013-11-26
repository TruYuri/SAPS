using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class BaseSystem
    {
        private static BaseSystem _instance;
        private StatisticsSystem _statisticsSystem;
        private ApplicationSystem _applicationSystem;
        private EventSystem _eventSystem;
        private EventTracker _eventTracker;
        private Database _database;

        public BaseSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public BaseSystem()
        {
            _instance = this;

            _statisticsSystem = new StatisticsSystem();
            _applicationSystem = new ApplicationSystem();
            _eventSystem = new EventSystem();
            _eventTracker = new EventTracker();
            _database = new Database();
        }
    }
}
