using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Gender { Male, Female };
enum StudentType { Undergraduate, Graduate };

namespace SAPS
{
    struct DatabaseEntry
    {
        string firstName;
        string middleName;
        string lastName;
        Gender gender;
        int age;
        float GPA;
        DateTime dateOfBirth;
        StudentType studentType;
        List<string> majors;
        List<string> minors;
        Dictionary<string, bool> graduateVotes;
        int approvalStage;
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

        public Serialize()
        {
            
        }

        public Populate()
        {
           
        }
    }
}
