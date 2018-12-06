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

        public static Course AddCourse(int subjectId, int duration, decimal cost)
        {
            CoursesEntities db = new CoursesEntities();
            Course newCourse = new Course();
            newCourse.SubjectId = subjectId;
            newCourse.Duration = duration;
            newCourse.Cost = cost;
            db.Courses.Add(newCourse);
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
            return newCourse;
        }

        //get lists from db

        public static List<Teacher> GetTeachers(List<CourseTeacher> courseTeachers = null)
        {
            List<Teacher> res;
            CoursesEntities db = new CoursesEntities();
            if (courseTeachers == null)
                res = db.Teachers.ToList();
            else
            {
                res = new List<Teacher>();
                courseTeachers.ForEach(p => res.Add(db.Teachers.Find(p.TeacherId)));
            }
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

        public static List<Topic> GetTopics(int courseId)
        {
            CoursesEntities db = new CoursesEntities();
            List<Topic> res = db.Topics.Where(p=>p.CourseId==courseId).ToList();
            db.Dispose();
            return res;
        }

        public static List<StudentView> GetStudentViews(List<CourseStudent> courseStudents = null)
        {
            CoursesEntities db = new CoursesEntities();
            List<StudentView> res;
            if (courseStudents == null)
                res = db.StudentViews.ToList();
            else
            {
                res = new List<StudentView>();
                courseStudents.ForEach(p => res.Add(db.StudentViews.Where(q=>q.Id == p.StudentId).First()));
            }
            db.Dispose();
            return res;
        }

        public static List<CourseView> GetCourseViews()
        {
            CoursesEntities db = new CoursesEntities();
            List<CourseView> res = db.CourseViews.ToList();
            db.Dispose();
            return res;
        }

        public static List<CoursesStudentsView> GetCourseStudentViews(List<CourseStudent> courseStudents = null)
        {
            CoursesEntities db = new CoursesEntities();
            List<CoursesStudentsView> res;
            if (courseStudents == null)
                res = db.CoursesStudentsViews.ToList();
            else
            {
                res = new List<CoursesStudentsView>();
                courseStudents.ForEach(p => res.Add(db.CoursesStudentsViews.Where(q => q.Id == p.StudentId).First()));
            }
            db.Dispose();
            return res;
        }

        //get entity from db

        public static Course GetCourse(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Course res = db.Courses.ToList().Find(p => p.Id == id);
            res.Topics = res.Topics.ToList();
            res.CoursesTeachers = res.CoursesTeachers.ToList();
            res.CoursesStudents = res.CoursesStudents.ToList();
            res.Subject.ToString();
            db.Dispose();
            return res;
        }
    }
}
