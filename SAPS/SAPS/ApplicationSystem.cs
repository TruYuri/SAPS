using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPS
{
    class ApplicationSystem
    {
        private static ApplicationSystem _instance;

        public ApplicationSystem Instance
        {
            get
            {
                return _instance;
            }
        }

        public ApplicationSystem()
        {
            _instance = this;
        }
    }
}
