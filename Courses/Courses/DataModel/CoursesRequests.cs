using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataModel
{
    static class CoursesRequests
    {
        public static Teacher AddTeacher(string name)
        {
            CoursesEntities db = new CoursesEntities();
            Teacher newTeacher = new Teacher();
            newTeacher.Name = name;
            db.Teachers.Add(newTeacher);
            try
            {
                db.SaveChanges();
                db.Dispose();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                db.Dispose();
                return null;
            }
            return newTeacher;
        }

        public static School AddSchool(string name)
        {
            CoursesEntities db = new CoursesEntities();
            School newSchool = new School();
            newSchool.Name = name;
            db.Schools.Add(newSchool);
            try
            {
                db.SaveChanges();
                db.Dispose();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                db.Dispose();
                return null;
            }
            return newSchool;
        }

        public static Subject AddSubject(string name)
        {
            CoursesEntities db = new CoursesEntities();
            Subject newSubject = new Subject();
            newSubject.Name = name;
            db.Subjects.Add(newSubject);
            try
            {
                db.SaveChanges();
                db.Dispose();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                db.Dispose();
                return null;
            }
            return newSubject;
        }
    }
}
