using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class StudentView
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ClassName { get; set; }
        public static bool StudentNameASC(StudentView a, StudentView b)
        {
            if (String.Compare(a.StudentName, b.StudentName) < 0)
                return true;
            return false;
        }
        public static bool StudentNameDES(StudentView a, StudentView b)
        {
            if (String.Compare(a.StudentName, b.StudentName) > 0)
                return true;
            return false;
        }
    }
}
