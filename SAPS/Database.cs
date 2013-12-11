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
            entry1.City = "Norfolk";
            entry1.State = "Nebraska";entry1.FirstName = "Kyle";
            entry1.MiddleName = "Marcus";
            entry1.LastName = "Reestman";
            entry1.Gender = Gender.Male;
            entry1.DateOfBirth = new DateTime(1993, 3, 15);
            entry1.SubmissionDate = new DateTime(2013, 12, 1);
            entry1.stage = Stage.Higher;
            entry1.votes.Add("upa", Vote.Approve);
            entry1.ACTSAT = 33;
            entry1.ClassRank = 9;
            entry1.GPA = 4.0f;
            entry1.StudentType = StudentType.Undergraduate;
            entry1.Majors.Add("Computer Science");
            _database.Add(entry1);

            DatabaseEntry entry2 = new DatabaseEntry();
            entry2.City = "Lincoln";
            entry2.State = "Nebraska";
            entry2.FirstName = "Lucas";
            entry2.MiddleName = "Benjamin";
            entry2.LastName = "Larson";
            entry2.Gender = Gender.Male;
            entry2.DateOfBirth = new DateTime(1990, 7, 17);
            entry2.SubmissionDate = new DateTime(2013, 11, 5);
            entry2.stage = Stage.Lower;
            entry2.votes.Add("gpc2", Vote.Approve);
            entry2.ACTSAT = 77;
            entry2.ClassRank = 47;
            entry2.GPA = 3.90f;
            entry2.StudentType = StudentType.Graduate;
            entry2.Majors.Add("Chemistry");
            entry2.Minors.Add("Biology");
            _database.Add(entry2);

            DatabaseEntry entry3 = new DatabaseEntry();
            entry3.City = "Council Bluffs";
            entry3.State = "Iowa";
            entry3.FirstName = "Jessse";
            entry3.MiddleName = "Kip";
            entry3.LastName = "Perkins";
            entry3.Gender = Gender.Male;
            entry3.DateOfBirth = new DateTime(1992, 2, 29);
            entry3.SubmissionDate = new DateTime(2013, 7, 19);
            entry3.stage = Stage.Higher;
            entry3.votes.Add("upa", Vote.Approve);
            entry3.ACTSAT = 25;
            entry3.ClassRank = 70;
            entry3.GPA = 3.45f;
            entry3.StudentType = StudentType.Undergraduate;
            entry3.Majors.Add("Geology");
            _database.Add(entry3);

            DatabaseEntry entry4 = new DatabaseEntry();
            entry4.City = "Omaha";
            entry4.State = "Nebraska";
            entry4.FirstName = "Otto";
            entry4.MiddleName = "Theodore";
            entry4.LastName = "Thompson";
            entry4.Gender = Gender.Male;
            entry4.DateOfBirth = new DateTime(1993, 5, 20);
            entry4.SubmissionDate = new DateTime(2013, 12, 2);
            entry4.stage = Stage.Lower;
            entry4.ACTSAT = 24;
            entry4.ClassRank = 124;
            entry4.GPA = 3.33f;
            entry4.StudentType = StudentType.Undergraduate;
            entry4.Majors.Add("Journalism");
            entry4.Minors.Add("Broadcasting");
            _database.Add(entry4);

            DatabaseEntry entry5 = new DatabaseEntry();
            entry5.City = "Omaha";
            entry5.State = "Nebraska";
            entry5.FirstName = "Brock";
            entry5.MiddleName = "Denny";
            entry5.LastName = "Evans";
            entry5.Gender = Gender.Male;
            entry5.DateOfBirth = new DateTime(1992, 12, 12);
            entry5.SubmissionDate = new DateTime(2013, 12, 4);
            entry5.stage = Stage.Lower;
            entry5.ACTSAT = 26;
            entry5.ClassRank = 94;
            entry5.GPA = 3.50f;
            entry5.StudentType = StudentType.Undergraduate;
            entry5.Majors.Add("International Studies");
            _database.Add(entry5);

            DatabaseEntry entry6 = new DatabaseEntry();
            entry6.City = "Lincoln";
            entry6.State = "Nebraska";
            entry6.FirstName = "Adrian";
            entry6.MiddleName = "Kirk";
            entry6.LastName = "Otten";
            entry6.Gender = Gender.Male;
            entry6.DateOfBirth = new DateTime(1994, 6, 14);
            entry6.SubmissionDate = new DateTime(2013, 11, 18);
            entry6.stage = Stage.Lower;
            entry6.ACTSAT = 30;
            entry6.ClassRank = 22;
            entry6.GPA = 3.96f;
            entry6.StudentType = StudentType.Undergraduate;
            entry6.Majors.Add("Civil Engineering");
            _database.Add(entry6);

            DatabaseEntry entry7 = new DatabaseEntry();
            entry7.City = "Bellevue";
            entry7.State = "Nebraska";
            entry7.FirstName = "Elijah";
            entry7.MiddleName = "Angus";
            entry7.LastName = "Ingram";
            entry7.Gender = Gender.Male;
            entry7.DateOfBirth = new DateTime(1995, 1, 17);
            entry7.SubmissionDate = new DateTime(2013, 12, 9);
            entry7.stage = Stage.Higher;
            entry7.votes.Add("upa", Vote.Approve);
            entry7.ACTSAT = 29;
            entry7.ClassRank = 103;
            entry7.GPA = 3.78f;
            entry7.StudentType = StudentType.Undergraduate;
            entry7.Majors.Add("Mathematics");
            _database.Add(entry7);

            DatabaseEntry entry8 = new DatabaseEntry();
            entry8.City = "Kearney";
            entry8.State = "Nebraska";
            entry8.FirstName = "David";
            entry8.MiddleName = "Austin";
            entry8.LastName = "Gray";
            entry8.Gender = Gender.Male;
            entry8.DateOfBirth = new DateTime(1996, 4, 3);
            entry8.SubmissionDate = new DateTime(2013, 12, 1);
            entry8.stage = Stage.Lower;
            entry8.ACTSAT = 25;
            entry8.ClassRank = 150;
            entry8.GPA = 3.10f;
            entry8.StudentType = StudentType.Undergraduate;
            entry8.Majors.Add("History");
            _database.Add(entry8);

            DatabaseEntry entry9 = new DatabaseEntry();
            entry9.City = "St. Joseph";
            entry9.State = "Missouri";
            entry9.FirstName = "Neil";
            entry9.MiddleName = "Paul";
            entry9.LastName = "Wilkins";
            entry9.Gender = Gender.Male;
            entry9.DateOfBirth = new DateTime(1991, 7, 19);
            entry9.SubmissionDate = new DateTime(2013, 9, 22);
            entry9.stage = Stage.Lower;
            entry9.ACTSAT = 27;
            entry9.ClassRank = 54;
            entry9.GPA = 3.73f;
            entry9.StudentType = StudentType.Graduate;
            entry9.Majors.Add("Secondary Education");
            _database.Add(entry9);

            DatabaseEntry entry10 = new DatabaseEntry();
            entry10.City = "Gretna";
            entry10.State = "Nebraska";
            entry10.FirstName = "Alexander";
            entry10.MiddleName = "John";
            entry10.LastName = "Simons";
            entry10.Gender = Gender.Male;
            entry10.DateOfBirth = new DateTime(1992, 3, 31);
            entry10.SubmissionDate = new DateTime(2013, 10, 10);
            entry10.stage = Stage.Higher;
            entry10.votes.Add("gpc1", Vote.Approve);
            entry10.votes.Add("gpc2", Vote.Approve);
            entry10.votes.Add("gpc3", Vote.Approve);
            entry10.votes.Add("gpc5", Vote.Approve);
            entry10.votes.Add("gpc6", Vote.Approve);
            entry10.ACTSAT = 34;
            entry10.ClassRank = 7;
            entry10.GPA = 4.0f;
            entry10.StudentType = StudentType.Graduate;
            entry10.Majors.Add("Architectural Engineering");
            _database.Add(entry10);

            DatabaseEntry entry11 = new DatabaseEntry();
            entry11.City = "Omaha";
            entry11.State = "Nebraska";
            entry11.FirstName = "Rose";
            entry11.MiddleName = "Alayna";
            entry11.LastName = "Garrett";
            entry11.Gender = Gender.Female;
            entry11.DateOfBirth = new DateTime(1995, 6, 10);
            entry11.SubmissionDate = new DateTime(2013, 8, 14);
            entry11.stage = Stage.Higher;
            entry11.votes.Add("upa", Vote.Approve);
            entry11.ACTSAT = 35;
            entry11.ClassRank = 3;
            entry11.GPA = 4.0f;
            entry11.StudentType = StudentType.Undergraduate;
            entry11.Majors.Add("Computer Engineering");
            _database.Add(entry11);

            DatabaseEntry entry12 = new DatabaseEntry();
            entry12.City = "Papillion";
            entry12.State = "Nebraska";
            entry12.FirstName = "Joanna";
            entry12.MiddleName = "Addison";
            entry12.LastName = "Randall";
            entry12.Gender = Gender.Female;
            entry12.DateOfBirth = new DateTime(1990, 11, 23);
            entry12.SubmissionDate = new DateTime(2013, 11, 2);
            entry12.stage = Stage.Lower;
            entry12.votes.Add("gpc4", Vote.Approve);
            entry12.votes.Add("gpc7", Vote.Approve);
            entry12.ACTSAT = 28;
            entry12.ClassRank = 94;
            entry12.GPA = 3.68f;
            entry12.StudentType = StudentType.Graduate;
            entry12.Majors.Add("Elementary Education");
            _database.Add(entry12);

            DatabaseEntry entry13 = new DatabaseEntry();
            entry13.City = "Council Bluffs";
            entry13.State = "Iowa";
            entry13.FirstName = "Carly";
            entry13.MiddleName = "Michelle";
            entry13.LastName = "Butler";
            entry13.Gender = Gender.Female;
            entry13.DateOfBirth = new DateTime(1995, 9, 7);
            entry13.SubmissionDate = new DateTime(2013, 12, 10);
            entry13.stage = Stage.Lower;
            entry13.ACTSAT = 24;
            entry13.ClassRank = 64;
            entry13.GPA = 3.71f;
            entry13.StudentType = StudentType.Undergraduate;
            entry13.Majors.Add("Social Work");
            _database.Add(entry13);

            DatabaseEntry entry14 = new DatabaseEntry();
            entry14.City = "Omaha";
            entry14.State = "Nebraska";
            entry14.FirstName = "Jenna";
            entry14.MiddleName = "Mary";
            entry14.LastName = "Branson";
            entry14.Gender = Gender.Female;
            entry14.DateOfBirth = new DateTime(1994, 8, 25);
            entry14.SubmissionDate = new DateTime(2013, 9, 8);
            entry14.stage = Stage.Higher;
            entry14.votes.Add("upa", Vote.Approve);
            entry14.ACTSAT = 30;
            entry14.ClassRank = 12;
            entry14.GPA = 4.0f;
            entry14.StudentType = StudentType.Undergraduate;
            entry14.Majors.Add("Biology");
            _database.Add(entry14);

            DatabaseEntry entry15 = new DatabaseEntry();
            entry15.City = "Lincoln";
            entry15.State = "Nebraska";
            entry15.FirstName = "Alice";
            entry15.MiddleName = "Cassandra";
            entry15.LastName = "Todd";
            entry15.Gender = Gender.Female;
            entry15.DateOfBirth = new DateTime(1995, 12, 4);
            entry15.SubmissionDate = new DateTime(2013, 11, 20);
            entry15.stage = Stage.Lower;
            entry15.ACTSAT = 29;
            entry15.ClassRank = 41;
            entry15.GPA = 3.97f;
            entry15.StudentType = StudentType.Undergraduate;
            entry15.Majors.Add("Public Health");
            _database.Add(entry15);

            DatabaseEntry entry16 = new DatabaseEntry();
            entry16.City = "Scottsbluff";
            entry16.State = "Nebraska";
            entry16.FirstName = "Morgan";
            entry16.MiddleName = "Paige";
            entry16.LastName = "Sandford";
            entry16.Gender = Gender.Female;
            entry16.DateOfBirth = new DateTime(1995, 9, 29);
            entry16.SubmissionDate = new DateTime(2013, 12, 6);
            entry16.stage = Stage.Lower;
            entry16.ACTSAT = 23;
            entry16.ClassRank = 81;
            entry16.GPA = 3.13f;
            entry16.StudentType = StudentType.Undergraduate;
            entry16.Majors.Add("Broadcasting");
            _database.Add(entry16);

            DatabaseEntry entry17 = new DatabaseEntry();
            entry17.City = "La Vista";
            entry17.State = "Nebraska";
            entry17.FirstName = "Melody";
            entry17.MiddleName = "Irene";
            entry17.LastName = "Berry";
            entry17.Gender = Gender.Female;
            entry17.DateOfBirth = new DateTime(1995, 4, 24);
            entry17.SubmissionDate = new DateTime(2013, 11, 22);
            entry17.stage = Stage.Lower;
            entry17.ACTSAT = 24;
            entry17.ClassRank = 104;
            entry17.GPA = 3.42f;
            entry17.StudentType = StudentType.Undergraduate;
            entry17.Majors.Add("International Studies");
            _database.Add(entry17);

            DatabaseEntry entry18 = new DatabaseEntry();
            entry18.City = "Hastings";
            entry18.State = "Nebraska";
            entry18.FirstName = "Wendy";
            entry18.MiddleName = "Francine";
            entry18.LastName = "Sargent";
            entry18.Gender = Gender.Female;
            entry18.DateOfBirth = new DateTime(1994, 5, 1);
            entry18.SubmissionDate = new DateTime(2013, 11, 25);
            entry18.stage = Stage.Lower;
            entry18.ACTSAT = 23;
            entry18.ClassRank = 133;
            entry18.GPA = 3.29f;
            entry18.StudentType = StudentType.Undergraduate;
            entry18.Majors.Add("Philosophy");
            entry18.Minors.Add("Religion");
            _database.Add(entry18);

            DatabaseEntry entry19 = new DatabaseEntry();
            entry19.City = "Omaha";
            entry19.State = "Nebraska";
            entry19.FirstName = "Naomi";
            entry19.MiddleName = "Katelyn";
            entry19.LastName = "Crouch";
            entry19.Gender = Gender.Female;
            entry19.DateOfBirth = new DateTime(1996, 2, 5);
            entry19.SubmissionDate = new DateTime(2013, 10, 3);
            entry19.stage = Stage.Higher;
            entry19.votes.Add("upa", Vote.Approve);
            entry19.ACTSAT = 32;
            entry19.ClassRank = 25;
            entry19.GPA = 3.88f;
            entry19.StudentType = StudentType.Undergraduate;
            entry19.Majors.Add("Management Information Systems");
            entry19.Minors.Add("Mathematics");
            _database.Add(entry19);

            DatabaseEntry entry20 = new DatabaseEntry();
            entry20.City = "Overland Park";
            entry20.State = "Kansas";
            entry20.FirstName = "Kim";
            entry20.MiddleName = "Lori";
            entry20.LastName = "Wright";
            entry20.Gender = Gender.Female;
            entry20.DateOfBirth = new DateTime(1990, 4, 1);
            entry20.SubmissionDate = new DateTime(2013, 10, 13);
            entry20.stage = Stage.Lower;
            entry20.ACTSAT = 22;
            entry20.ClassRank = 228;
            entry20.GPA = 3.0f;
            entry20.StudentType = StudentType.Undergraduate;
            entry20.Majors.Add("Undeclared");
            _database.Add(entry20);

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
