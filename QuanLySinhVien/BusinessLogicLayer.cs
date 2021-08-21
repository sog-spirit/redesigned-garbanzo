using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class BusinessLogicLayer
    {
        public delegate bool CompareFunc(StudentView a, StudentView b);
        private static BusinessLogicLayer _Instance;
        public static BusinessLogicLayer Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BusinessLogicLayer();
                return _Instance;
            }
            private set { }
        }
        public List<StudentView> GetStudents(string studentName, int classID)
        {
            List<StudentView> students = DataAccessLayer.Instance.GetStudents(studentName.ToLower(), classID);
            return students;
        }
        public Student GetStudent(string studentID)
        {
            return DataAccessLayer.Instance.GetStudent(studentID);
        }
        public List<Class> GetClasses()
        {
            return DataAccessLayer.Instance.GetClasses();
        }
        public void DeleteStudent(string studentID)
        {
            DataAccessLayer.Instance.DeleteStudent(studentID);
        }
        public void AddStudent(Student student)
        {
            DataAccessLayer.Instance.AddStudent(student);
        }
        public void EditStudent(Student student)
        {
            DataAccessLayer.Instance.EditStudent(student);
        }
        public bool StudentIsExist(string studentID)
        {
            if (DataAccessLayer.Instance.GetStudent(studentID) != null)
                return true;
            return false;
        }
        public List<StudentView> SortStudentViews(CompareFunc compareFunc, string input, int selectedClass)
        {
            List<StudentView> studentViews = GetStudents(input.ToLower(), selectedClass);
            StudentView temp = new StudentView();
            for (int i = 0; i < studentViews.Count; i++)
            {
                for (int j = 0; j < studentViews.Count; j++)
                {
                    if (compareFunc(studentViews[i], studentViews[j]))
                    {
                        temp = studentViews[i];
                        studentViews[i] = studentViews[j];
                        studentViews[j] = temp;
                    }
                }
            }
            return studentViews;
        }
        public bool ClassIsExist(int classValue, string className)
        {
            List<Class> classes = DataAccessLayer.Instance.GetClasses();
            foreach (Class @class in classes)
            {
                if (@class.ClassName.ToLower().Equals(className) || @class.ClassID == classValue)
                    return true;
            }
            return false;
        }
        public void AddClass(string className, int classValue)
        {
            DataAccessLayer.Instance.AddClass(className, classValue);
        }
    }
}
