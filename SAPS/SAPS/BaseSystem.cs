using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

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

        public static BaseSystem Instance
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

        public void Populate()
        {
            DataContractJsonSerializer serializer;
            MemoryStream stream = new MemoryStream();

            serializer = new DataContractJsonSerializer(typeof(DatabaseEntry));
            _database.Populate(serializer, stream);

            serializer = new DataContractJsonSerializer(typeof(EventEntry));
            _eventTracker.Populate(serializer, stream);

            stream.Close();
        }

        public void Serialize()
        {
            DataContractJsonSerializer serializer;
            MemoryStream stream = new MemoryStream();

            serializer = new DataContractJsonSerializer(typeof(DatabaseEntry));
            _database.Serialize(serializer, stream);

            serializer = new DataContractJsonSerializer(typeof(EventEntry));
            _eventTracker.Serialize(serializer, stream);

            stream.Close();
        }
    }
}
