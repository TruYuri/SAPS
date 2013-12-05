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
        public string firstName;
        public string middleName;
        public string lastName;
        public Gender gender;
        public float GPA;
        public DateTime dateOfBirth;
        public DateTime submissionDate;
        public StudentType studentType;
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
            entry1.firstName = "Austin";
            entry1.middleName = "K.";
            entry1.lastName = "Koehler";
            entry1.gender = Gender.Male;
            entry1.GPA = 3.41f;
            entry1.dateOfBirth = new DateTime(1992, 12, 12);
            entry1.submissionDate = new DateTime(2011, 1, 1);
            entry1.studentType = StudentType.Undergraduate;
            entry1.majors.Add("Computer Science");
            entry1.minors.Add("None");
            entry1.votes.Add("test", Vote.Approve);
            entry1.stage = Stage.Higher;
            entry1.comments = "Test set of comments.";
            _database.Add(entry1);

            DatabaseEntry entry2 = new DatabaseEntry();
            entry2.firstName = "Kylie";
            entry2.middleName = "Elizabeth";
            entry2.lastName = "Ressmen";
            entry2.gender = Gender.Female;
            entry2.GPA = 4.0f;
            entry2.dateOfBirth = new DateTime(1973, 6, 14);
            entry2.submissionDate = new DateTime(2012, 1, 1);
            entry2.studentType = StudentType.Graduate;
            entry2.majors.Add("Flowers");
            entry2.minors.Add("Buttercups");
            entry2.minors.Add("Ponies");
            entry2.votes.Add("Jackass", Vote.Approve);
            entry2.votes.Add("Mom", Vote.Reject);
            entry2.stage = Stage.Lower;
            entry2.comments = "Test set of comments 2.";
            _database.Add(entry2);

            // Filter by User.Instance.Permissions and Stage
            //foreach {}
            ApplicationSystem.Instance.Entries = _database; // temp
        }
    }
}
