using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

enum Gender { Male, Female };
enum StudentType { Undergraduate, Graduate };

namespace SAPS
{
    [DataContract]
    class DatabaseEntry
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public Gender gender;
        public int age;
        public float GPA;
        public DateTime dateOfBirth;
        public StudentType studentType;
        public List<string> majors;
        public List<string> minors;
        public Dictionary<string, bool> graduateVotes;
        public int approvalStage;
    }

    class Database
    {
        private static Database _instance;

        List<DatabaseEntry> _database;
        List<DatabaseEntry> _availableEntries;

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

            // Load database to _database

            // Filter to User.Instance.Permissions
        }

        public void Serialize()
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DatabaseEntry)); 
            MemoryStream ms1 = new MemoryStream();
            serializer.WriteObject(ms1, _database);
        }

        public void Populate()
        {
           
        }
    }
}
