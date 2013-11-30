using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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

        public void Serialize()
        {
            StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\DATABASE.DB");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            // string json;

            // json = _database.Serialize(serializer) + _eventTracker.Serialize(serializer);
            writer.Write(_database.Serialize(serializer));
            writer.Write("\n");
            writer.Write(_eventTracker.Serialize(serializer));
            writer.Write("\n");
            writer.Close();
            // File.WriteAllText(Environment.CurrentDirectory + @"\DATABASE.DB", json);
        }

        public void Populate()
        {
            StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\DATABASE.DB");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json;

            json = reader.ReadLine();
            if(json == null) // temp
                json = "";
            _database.Populate(serializer, json);
            json = reader.ReadLine();
            if(json == null) // temp
                json = "";
            _eventTracker.Populate(serializer, json);

            reader.Close();
        }
    }
}
