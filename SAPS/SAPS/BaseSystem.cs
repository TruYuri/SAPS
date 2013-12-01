using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace SAPS
{
    public class BaseSystem
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

        public bool Login(string email, string password)
        {
            // check online database for user:
            // send email
            // send password

            // retrieve name
            // retrieve user type

            // if successful
            User user = new User(email, email, UserType.All);

            // load database
            Populate();

            return true;
        }

        public void Logout()
        {
            Serialize();
            User.Instance.Destroy();
        }

        private void Serialize()
        {
            StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\DATABASE.DB");
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            writer.Write(_database.Serialize(serializer));
            writer.Write("\n");
            writer.Write(_eventTracker.Serialize(serializer));
            writer.Write("\n");
            writer.Close();
        }

        private void Populate()
        {
            try
            {
                StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\DATABASE.DB");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json;

                json = reader.ReadLine();
                if (json == null) // temp
                    json = "";
                _database.Populate(serializer, json);
                json = reader.ReadLine();
                if (json == null) // temp
                    json = "";
                _eventTracker.Populate(serializer, json);

                reader.Close();
            }
            catch(FileNotFoundException fnfe)
            {
                StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\DATABASE.DB");
                writer.Close();
            }
        }
    }
}
