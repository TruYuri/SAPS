using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Gender { Male, Female };
enum StudentType { Undergraduate, Graduate };

namespace SAPS
{
    struct Entry
    {
        string firstName;
        string middleName;
        string lastName;
        int age;
        float GPA;
        DateTime dateOfBirth;
        StudentType studentType;
        Gender gender;
        List<string> majors;
        List<string> minors;
    }

    class Database
    {
        private static Database _instance;

        public Database Instance
        {
            get
            {
                return _instance;
            }
        }

        public Database()
        {
            _instance = this;
        }
    }
}
