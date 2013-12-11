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
        [Browsable(false)] public StudentType StudentType { get; set; }
        [Browsable(false)] public DateTime SubmissionDate { get; set; }
        [Browsable(false)] public string FirstName { get; set; }
        [Browsable(false)] public string MiddleName { get; set; }
        [Browsable(false)] public string LastName { get; set; }
        [Browsable(false)] public Gender Gender { get; set; }
        [Browsable(false)] public DateTime DateOfBirth { get; set; }
        [Browsable(false)] public string SocialSecurity { get; set; }
        [Browsable(false)] public string StreetAddress { get; set; }
        [Browsable(false)] public string City { get; set; }
        [Browsable(false)] public string State { get; set; }
        [Browsable(false)] public string Zip { get; set; }
        [Browsable(false)] public string Phone { get; set; }
        [Browsable(false)] public float GPA { get; set; }
        [Browsable(false)] public int ACTSAT { get; set; }
        [Browsable(false)] public int ClassRank { get; set; }
        [Browsable(false)] public BindingList<string> Majors { get; set; }
        [Browsable(false)] public BindingList<string> Minors { get; set; }
        public Dictionary<string, Vote> votes;
        [Browsable(false)] public string Comments { get; set; }

        [ScriptIgnore] public string Name
        {
            get
            {
                return LastName + ", " + FirstName + " " + MiddleName;
            }
        }

        [ScriptIgnore] public string Major
        {
            get
            {
                string m = Majors[0];

                for(int i = 1; i < Majors.Count; i++)
                {
                    m += ", " + Majors[i];
                }

                return m;
            }
        }

        [ScriptIgnore] public string Date
        {
            get
            {
                return SubmissionDate.ToString();
            }
        }

        public DatabaseEntry()
        {
            Majors = new BindingList<string>();
            Minors = new BindingList<string>();
            votes = new Dictionary<string, Vote>();
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

        public void Populate(JavaScriptSerializer serializer, string json, User user)
        {
            _database = serializer.Deserialize<BindingList<DatabaseEntry>>(json);

            if(_database == null)
            {
                _database = new BindingList<DatabaseEntry>();
            }
            
            DatabaseEntry entry1 = new DatabaseEntry();
            entry1.FirstName = "Undergraduate";
            entry1.MiddleName = "";
            entry1.LastName = "Higher";
            entry1.Gender = Gender.Male;
            entry1.GPA = 3.41f;
            entry1.City = "Lincoln";
            entry1.State = "Nebraska";
            entry1.DateOfBirth = new DateTime(1992, 12, 12);
            entry1.SubmissionDate = new DateTime(2011, 1, 1);
            entry1.StudentType = StudentType.Undergraduate;
            entry1.Majors.Add("Computer Science");
            entry1.votes.Add("test", Vote.Approve);
            entry1.stage = Stage.Higher;
            entry1.Comments = "Test set of comments.";
            entry1.StreetAddress = "butts";
            entry1.SocialSecurity = "1234567";
            entry1.Zip = "68701";
            entry1.Phone = "balls";
            entry1.ACTSAT = 34;
            entry1.ClassRank = 99;
            _database.Add(entry1);

            DatabaseEntry entry2 = new DatabaseEntry();
            entry2.FirstName = "Graduate";
            entry2.MiddleName = "";
            entry2.LastName = "Lower";
            entry2.Gender = Gender.Female;
            entry2.City = "Norfolk";
            entry2.State = "Nebraska";
            entry2.GPA = 4.0f;
            entry2.ACTSAT = 17;
            entry2.DateOfBirth = new DateTime(1973, 6, 14);
            entry2.SubmissionDate = new DateTime(2012, 1, 1);
            entry2.StudentType = StudentType.Graduate;
            entry2.Majors.Add("Chemistry");
            entry2.Minors.Add("Economics");
            entry2.Minors.Add("General Science");
            entry2.votes.Add("Austin", Vote.Approve);
            entry2.votes.Add("Mom", Vote.Reject);
            entry2.stage = Stage.Lower;
            entry2.Comments = "Test set of comments 2.";
            _database.Add(entry2);

            DatabaseEntry entry3 = new DatabaseEntry();
            entry3.City = "Omaha";
            entry3.State = "Iowa";
            entry3.FirstName = "Graduate";
            entry3.LastName = "Higher";
            entry3.stage = Stage.Higher;
            entry3.ACTSAT = 25;
            entry3.StudentType = StudentType.Graduate;
            entry3.Majors.Add("Geology");
            _database.Add(entry3);

            DatabaseEntry entry4 = new DatabaseEntry();
            entry4.City = "Omaha";
            entry4.State = "New Jersey";
            entry4.FirstName = "Undergraduate";
            entry4.Gender = Gender.Male;
            entry4.LastName = "Lower";
            entry4.stage = Stage.Lower;
            entry4.ACTSAT = 17;
            entry4.StudentType = StudentType.Undergraduate;
            entry4.Majors.Add("Journalism");
            _database.Add(entry4);

            BindingList<DatabaseEntry> list = new BindingList<DatabaseEntry>();
            // Filter by User.Instance.Permissions and Stage

            foreach(DatabaseEntry entry in _database)
            {
                if (user.Permissions == UserType.All)
                {
                    list.Add(entry);
                }
                else if (entry.StudentType == StudentType.Undergraduate)
                {
                    if ((entry.stage == Stage.Lower && user.Permissions == UserType.UPA)
                        || (entry.stage == Stage.Higher && user.Permissions == UserType.UPC))
                    {
                        list.Add(entry);
                    }
                }
                else if ((entry.stage == Stage.Lower && user.Permissions == UserType.GPC && !entry.votes.ContainsKey(user.Name))
                        || (entry.stage == Stage.Higher && user.Permissions == UserType.GPCC))
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

        public void Add(DatabaseEntry entry)
        {
            _database.Add(entry);
        }

        public void Clear()
        {
            _database = null;
        }
    }
}
