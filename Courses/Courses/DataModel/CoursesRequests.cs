using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataModel
{
    static class CoursesRequests
    {
        //add to db

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

        public static Student AddStudent(string name,int group,int schoolId)
        {
            CoursesEntities db = new CoursesEntities();
            Student newStudent = new Student();
            newStudent.Name = name;
            newStudent.GroupN = group;
            newStudent.SchoolId = schoolId;
            db.Students.Add(newStudent);
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
            return newStudent;
        }

        //get from db

        public static List<Teacher> GetTeachers()
        {
            CoursesEntities db = new CoursesEntities();
            List<Teacher> res = db.Teachers.ToList();
            db.Dispose();
            return res;
        }

        public static List<School> GetSchools()
        {
            CoursesEntities db = new CoursesEntities();
            List<School> res = db.Schools.ToList();
            db.Dispose();
            return res;
        }

        public static List<Subject> GetSubjects()
        {
            CoursesEntities db = new CoursesEntities();
            List<Subject> res = db.Subjects.ToList();
            db.Dispose();
            return res;
        }

        public static List<StudentView> GetStudentViews()
        {
            CoursesEntities db = new CoursesEntities();
            List<StudentView> res = db.StudentViews.ToList();
            db.Dispose();
            return res;
        }
    }
}
