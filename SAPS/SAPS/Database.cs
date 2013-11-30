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
enum Stage { Rejected, Lower, Higher, Approved };

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
        [DataMember] public Stage stage;
        [DataMember] public string comments;
    }

    class Database
    {
        private static Database _instance;
        private List<DatabaseEntry> _database;
        private List<DatabaseEntry> _availableEntries;

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
            _database = new List<DatabaseEntry>();
            _availableEntries = new List<DatabaseEntry>();
        }

        public void Serialize(DataContractJsonSerializer serializer, MemoryStream stream)
        {
            serializer.WriteObject(stream, _database);
        }

        public void Populate(DataContractJsonSerializer serializer, MemoryStream stream)
        {
            _database = serializer.ReadObject(stream) as List<DatabaseEntry>;

            // Filter by User.Instance.Permissions and Stage
        }
    }
}
