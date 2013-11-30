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
        [DataMember] public string firstName;
        [DataMember] public string middleName;
        [DataMember] public string lastName;
        [DataMember] public Gender gender;
        [DataMember] public int age;
        [DataMember] public float GPA;
        [DataMember] public DateTime dateOfBirth;
        [DataMember] public StudentType studentType;
        [DataMember] public List<string> majors;
        [DataMember] public List<string> minors;
        [DataMember] public Dictionary<string, bool> graduateVotes;
        [DataMember] public int approvalStage;
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
