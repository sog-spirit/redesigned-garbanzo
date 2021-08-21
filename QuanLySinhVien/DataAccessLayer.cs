using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class DataAccessLayer
    {
        private ProgramContext programContext = new ProgramContext();
        private static DataAccessLayer _Instance;
        public static DataAccessLayer Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DataAccessLayer();
                return _Instance;
            }
            private set { }
        }

        public List<StudentView> GetStudents(string nameInput, int selectedClassID)
        {
            List<StudentView> students = new List<StudentView>();
            if(selectedClassID == 0)
            {
                var queryAll = from _student in programContext.students
                               join _class in programContext.classes
                               on _student.ClassID equals _class.ClassID
                               where _student.StudentName.ToLower().Contains(nameInput)
                               select new
                               {
                                   _student.StudentID,
                                   _student.StudentName,
                                   _student.DOB,
                                   _student.Gender,
                                   _class.ClassName
                               };
                foreach(var item in queryAll)
                {
                    students.Add(new StudentView()
                    {
                        StudentID = item.StudentID,
                        StudentName = item.StudentName,
                        DateOfBirth = item.DOB,
                        Gender = item.Gender,
                        ClassName = item.ClassName
                    });
                }
                return students;
            }
            var query = from _student in programContext.students
                        join _class in programContext.classes
                        on _student.ClassID equals _class.ClassID
                        where _student.StudentName.ToLower().Contains(nameInput) && _student.ClassID == selectedClassID
                        select new
                        {
                            _student.StudentID,
                            _student.StudentName,
                            _student.DOB,
                            _student.Gender,
                            _class.ClassName
                        };
            foreach (var item in query)
            {
                students.Add(new StudentView()
                {
                    StudentID = item.StudentID,
                    StudentName = item.StudentName,
                    DateOfBirth = item.DOB,
                    Gender = item.Gender,
                    ClassName = item.ClassName
                });
            }
            return students;
        }
        public Student GetStudent(string studentID)
        {
            Student student = new Student();
            var query = programContext.students.FirstOrDefault(_student => _student.StudentID == studentID);
            student = query;
            return student;
        }
        public List<Class> GetClasses()
        {
            List<Class> classes = new List<Class>();
            var query = from Classtable in programContext.classes
                        select Classtable;
            classes = query.ToList();
            return classes;
        }
        public void AddStudent(Student student)
        {
            programContext.students.Add(student);
            programContext.SaveChanges();
        }
        public void EditStudent(Student student)
        {
            var query = from _student in programContext.students
                        where _student.StudentID == student.StudentID
                        select _student;
            foreach (Student item in query)
            {
                item.StudentName = student.StudentName;
                item.Gender = student.Gender;
                item.DOB = student.DOB;
                item.ClassID = student.ClassID;
            }
            programContext.SaveChanges();
        }
        public void DeleteStudent(string studentID)
        {
            var query = from _student in programContext.students
                        where _student.StudentID == studentID
                        select _student;
            foreach (Student item in query)
            {
                programContext.students.Remove(item);
            }
            programContext.SaveChanges();
        }
        public void AddClass(string className, int classValue)
        {
            Class @class = new Class()
            {
                ClassID = classValue,
                ClassName = className
            };
            programContext.classes.Add(@class);
            programContext.SaveChanges();
        }
    }
}
