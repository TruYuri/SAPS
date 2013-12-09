using System;
using System.Linq;
using System.Collections.Generic;

namespace SAPS
{
    public class CollegeData
    {
        public static int CommitteeMembers = 7;

        public static List<string> Colleges = new List<string>()
        {
            "Arts and Sciences",
            "Business Administration",
            "Communications, Fine Arts, and Media",
            "Education",
            "Engineering",
            "Information Science and Technology",
            "Public Affairs and Community Service"
        };

        public static Dictionary<string, string> Majors = new Dictionary<string,string>()
        {
            {"Undeclared", "None"},
            {"Psychology", "Arts and Sciences"},
            {"Religion", "Arts and Sciences"},
            {"Sociology", "Arts and Sciences"},
            {"Womens and Gender Studies", "Arts and Sciences"},
            {"Biology", "Arts and Sciences"},
            {"Biotechnology", "Arts and Sciences"},
            {"Black Studies", "Arts and Sciences"},
            {"Chemistry", "Arts and Sciences"},
            {"Economics", "Arts and Sciences"},
            {"English", "Arts and Sciences"},
            {"Environmental Studies", "Arts and Sciences"},
            {"Foreign Language and Literature", "Arts and Sciences"},
            {"General Science", "Arts and Sciences"},
            {"Geography", "Arts and Sciences"},
            {"Geology", "Arts and Sciences"},
            {"History", "Arts and Sciences"}	,
            {"Interdisciplinary Studies", "Arts and Sciences"},	
            {"International Studies", "Arts and Sciences"},
            {"Latino/Latin American Studies", "Arts and Sciences"},
            {"Mathematics", "Arts and Sciences"},
            {"Neuroscience", "Arts and Sciences"},
            {"Philosophy", "Arts and Sciences"},
            {"Physics", "Arts and Sciences"},
            {"Political Science", "Arts and Sciences"},
            {"Business Administration", "Business Administration"},
            {"Speech Communication", "Communications, Fine Arts, and Media"},
            {"Studio Art", "Communications, Fine Arts, and Media"},
            {"Theatre", "Communications, Fine Arts, and Media"},
            {"Art History", "Communications, Fine Arts, and Media"},
            {"Broadcasting", "Communications, Fine Arts, and Media"},
            {"Creative Writing", "Communications, Fine Arts, and Media"},
            {"Journalism", "Communications, Fine Arts, and Media"},
            {"Music Education", "Communications, Fine Arts, and Media"},
            {"Music Performance", "Communications, Fine Arts, and Media"},
            {"Public Health", "Education"},
            {"Recreation and Leisure Studies", "Education"},
            {"Secondary Education", "Education"},
            {"Special Education", "Education"},
            {"Speech-Language Pathology", "Education"},
            {"Athletic Training", "Education"},
            {"Community Health", "Education"},
            {"Elementary Education", "Education"},
            {"Elementary Education, Special Education", "Education"},
            {"Library Science", "Education"},
            {"Physical Education", "Education"},
            {"Architectural Engineering", "Engineering"},
            {"Civil Engineering", "Engineering"},
            {"Computer Engineering", "Engineering"},
            {"Construction Engineering", "Engineering"},
            {"Construction Management", "Engineering"},
            {"Electronics Engineering", "Engineering"},
            {"Bioinformatics", "Information Science and Technology"},
            {"Computer Science", "Information Science and Technology"},
            {"Information Assurance", "Information Science and Technology"},
            {"IT Innovation", "Information Science and Technology"},
            {"Management Information Systems", "Information Science and Technology"},
            {"Social Work", "Public Affairs and Community Service"},
            {"Aviation", "Public Affairs and Community Service"},
            {"Criminology and Criminal Justice", "Public Affairs and Community Service"},
            {"Emergency Management", "Public Affairs and Community Service"},
            {"General Studies", "Public Affairs and Community Service"}
        };

        public static Dictionary<int[], int> SATtoACT = new Dictionary<int[], int>()
        {
            {Enumerable.Range(510, 550).ToArray(),   12},
            {Enumerable.Range(560, 610).ToArray(),   12},
            {Enumerable.Range(620, 660).ToArray(),   13},
            {Enumerable.Range(670, 710).ToArray(),   14},
            {Enumerable.Range(720, 760).ToArray(),   15},
            {Enumerable.Range(770, 810).ToArray(),   16},
            {Enumerable.Range(820, 850).ToArray(),   17},
            {Enumerable.Range(860, 890).ToArray(),   18},
            {Enumerable.Range(900, 930).ToArray(),   19},
            {Enumerable.Range(940, 970).ToArray(),   20},
            {Enumerable.Range(980, 1010).ToArray(),  21},
            {Enumerable.Range(1020, 1040).ToArray(), 22},
            {Enumerable.Range(1050, 1080).ToArray(), 23},
            {Enumerable.Range(1090, 1120).ToArray(), 24},
            {Enumerable.Range(1130, 1160).ToArray(), 25},
            {Enumerable.Range(1170, 1200).ToArray(), 26},
            {Enumerable.Range(1210, 1240).ToArray(), 27},
            {Enumerable.Range(1250, 1280).ToArray(), 28},
            {Enumerable.Range(1290, 1320).ToArray(), 29},
            {Enumerable.Range(1330, 1350).ToArray(), 30},
            {Enumerable.Range(1360, 1390).ToArray(), 31},
            {Enumerable.Range(1400, 1430).ToArray(), 32},
            {Enumerable.Range(1440, 1480).ToArray(), 33},
            {Enumerable.Range(1490, 1530).ToArray(), 34},
            {Enumerable.Range(1540, 1590).ToArray(), 35},
            {Enumerable.Range(1600, 1600).ToArray(), 36}
        };
    }
}
