using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using System.Windows.Forms;

namespace SAPS
{
    public class BaseSystem
    {
        // record web connection information

        // retain links to other systems
        private static BaseSystem _instance;
        private StatisticsSystem _statisticsSystem;
        private ApplicationSystem _applicationSystem;
        private EventSystem _eventSystem;
        private EventTracker _eventTracker;
        private Database _database;
        private User _user;

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

        public bool Login(string email, string password, Label nameLabel, Label nameError, Label passwordError)
        {
            nameError.Visible = false;
            passwordError.Visible = false;

            if (CollegeData.Accounts.Keys.Contains(email))
            {
                if (CollegeData.Accounts[email].Password == password)
                {
                    _applicationSystem.User = _user = CollegeData.Accounts[email];
                    nameLabel.Text = _user.Name;
                    Populate();
                    return true;
                }
                else
                {
                    passwordError.Visible = true;
                    passwordError.Text = "Invalid email/password combination!";
                }
            }
            else
            {
                nameError.Visible = true;
                nameError.Text = "Invalid user email!";
            }

            return false;
        }

        public void Logout()
        {
            Serialize();
            _database.Clear();
            _user = null;
        }

        public void Serialize()
        {
            StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\DATABASE.DB");
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            writer.Write(_database.Serialize(serializer));
            writer.Write("\n");
            writer.Write(_eventTracker.Serialize(serializer));
            writer.Write("\n");
            writer.Close();
        }

        public void Populate()
        {
            try
            {
                StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\DATABASE.DB");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json;

                json = reader.ReadLine();
                if (json == null) // temp
                    json = "";
                _database.Populate(serializer, json, _user);
                json = reader.ReadLine();
                if (json == null) // temp
                    json = "";
                _eventTracker.Populate(serializer, json);
                
                reader.Close();
            }
            catch
            {
                StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + @"\DATABASE.DB");
                writer.Close();
                Populate();
            }
        }
    }
}
