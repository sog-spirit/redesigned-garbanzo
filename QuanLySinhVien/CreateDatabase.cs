using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class CreateDatabase : CreateDatabaseIfNotExists<ProgramContext>
    {
        protected override void Seed(ProgramContext context)
        {
            context.classes.AddRange(new Class[]
            {
                new Class {ClassID = 1, ClassName = "Lop 1"},
                new Class {ClassID = 2, ClassName = "Lop 2"}
            });
            context.students.AddRange(new Student[]
            {
                new Student {StudentID = "1", StudentName = "A", DOB = DateTime.Now, Gender = true, ClassID = 1},
                new Student {StudentID = "2", StudentName = "B", DOB = DateTime.Now, Gender = false, ClassID = 2}
            });
        }
    }
}
