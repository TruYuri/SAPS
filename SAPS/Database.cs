using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.ComponentModel;

namespace SAPS
{
    public class DatabaseEntry
    {
        public Stage stage; // for filtering only
        public StudentType studentType;
        public DateTime submissionDate;
        public string firstName;
        public string middleName;
        public string lastName;
        public Gender gender;
        public DateTime dateOfBirth;
        public string socialSecurity;
        public string streetAddress;
        public string city;
        public string state;
        public string zip;
        public string phone;
        public float GPA;
        public int actSAT;
        public int classRank;
        public BindingList<string> majors = new BindingList<string>();
        public BindingList<string> minors = new BindingList<string>();
        public Dictionary<string, Vote> votes = new Dictionary<string, Vote>();
        public string comments;

        [ScriptIgnore] public string Name
        {
            get
            {
                return lastName + ", " + firstName + " " + middleName;
            }
        }

        [ScriptIgnore] public string Majors
        {
            get
            {
                string m = majors[0];

                for(int i = 1; i < majors.Count; i++)
                {
                    m += ", " + majors[i];
                }

                return m;
            }
        }

        [ScriptIgnore] public string SubmissionDate
        {
            get
            {
                return submissionDate.ToString();
            }
        }
    }

    class Database
    {
        private static Database _instance;
        private BindingList<DatabaseEntry> _database;

        public static Database Instance
        {
            get
            {
                return _instance;
            }
        }

        public Database()
        {
            _instance = this;
            _database = new BindingList<DatabaseEntry>();
        }

        public string Serialize(JavaScriptSerializer serializer)
        {
            return serializer.Serialize(_database);
        }

        public void Populate(JavaScriptSerializer serializer, string json)
        {
            _database = serializer.Deserialize<BindingList<DatabaseEntry>>(json);

            if(_database == null)
            {
                _database = new BindingList<DatabaseEntry>();
            }
            
            DatabaseEntry entry1 = new DatabaseEntry();
            entry1.firstName = "Undergraduate";
            entry1.middleName = "";
            entry1.lastName = "Higher";
            entry1.gender = Gender.Male;
            entry1.GPA = 3.41f;
            entry1.dateOfBirth = new DateTime(1992, 12, 12);
            entry1.submissionDate = new DateTime(2011, 1, 1);
            entry1.studentType = StudentType.Undergraduate;
            entry1.majors.Add("Computer Science");
            entry1.votes.Add("test", Vote.Approve);
            entry1.stage = Stage.Higher;
            entry1.comments = "Test set of comments.";
            entry1.streetAddress = "butts";
            entry1.socialSecurity = "1234567";
            entry1.city = "city";
            entry1.state = "derpity";
            entry1.zip = "68701";
            entry1.phone = "balls";
            entry1.actSAT = 34;
            entry1.classRank = 99;
            _database.Add(entry1);

            DatabaseEntry entry2 = new DatabaseEntry();
            entry2.firstName = "Graduate";
            entry2.middleName = "";
            entry2.lastName = "Lower";
            entry2.gender = Gender.Female;
            entry2.GPA = 4.0f;
            entry2.actSAT = 17;
            entry2.dateOfBirth = new DateTime(1973, 6, 14);
            entry2.submissionDate = new DateTime(2012, 1, 1);
            entry2.studentType = StudentType.Graduate;
            entry2.majors.Add("Chemistry");
            entry2.minors.Add("Buttercups");
            entry2.minors.Add("Ponies");
            entry2.votes.Add("Austin", Vote.Approve);
            entry2.votes.Add("Mom", Vote.Reject);
            entry2.stage = Stage.Lower;
            entry2.comments = "Test set of comments 2.";
            _database.Add(entry2);

            DatabaseEntry entry3 = new DatabaseEntry();
            entry3.firstName = "Graduate";
            entry3.lastName = "Higher";
            entry3.stage = Stage.Higher;
            entry3.actSAT = 25;
            entry3.studentType = StudentType.Graduate;
            entry3.majors.Add("Geology");
            _database.Add(entry3);

            DatabaseEntry entry4 = new DatabaseEntry();
            entry4.firstName = "Undergraduate";
            entry4.lastName = "Lower";
            entry4.stage = Stage.Lower;
            entry4.actSAT = 17;
            entry4.studentType = StudentType.Undergraduate;
            entry4.majors.Add("Journalism");
            _database.Add(entry4);

            BindingList<DatabaseEntry> list = new BindingList<DatabaseEntry>();
            // Filter by User.Instance.Permissions and Stage

            UserType user = User.Instance.Permissions;
            foreach(DatabaseEntry entry in _database)
            {
                if (user == UserType.All)
                {
                    list.Add(entry);
                }
                else if (entry.studentType == StudentType.Undergraduate)
                {
                    if ((entry.stage == Stage.Lower && user == UserType.UPA)
                        || (entry.stage == Stage.Higher && user == UserType.UPC))
                    {
                        list.Add(entry);
                    }
                }
                else if ((entry.stage == Stage.Lower && user == UserType.GPC && !entry.votes.ContainsKey(User.Instance.Name))
                        || (entry.stage == Stage.Higher && user == UserType.GPCC))
                {
                    list.Add(entry);
                }
            }

            ApplicationSystem.Instance.Entries = list;
            StatisticsSystem.Instance.Source = _database;
        }

        public void Remove(DatabaseEntry entry)
        {
            _database.Remove(entry);
        }
    }
}
