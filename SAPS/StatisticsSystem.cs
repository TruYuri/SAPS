using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class StatisticsSystem
    {
        private static StatisticsSystem _instance;

        public static StatisticsSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public StatisticsSystem()
        {
            _instance = this;
        }
    }
}
