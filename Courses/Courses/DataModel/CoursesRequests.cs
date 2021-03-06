﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Courses.DataModel
{
    static class CoursesRequests
    {
        //add to db

        public static Teacher AddTeacher(string name)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Teachers.Where(p => p.Name == name).Count() != 0)
                return null;
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
            if (db.Schools.Where(p => p.Name == name).Count() != 0)
                return null;
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
            if (db.Subjects.Where(p => p.Name == name).Count() != 0)
                return null;
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
            if (db.Students.Where(p => p.Name == name && p.GroupN == group && p.SchoolId == schoolId).Count() != 0)
                return null;
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
            if (db.Courses.Where(p => p.SubjectId == subjectId && p.Duration == duration && p.Cost == cost).Count() != 0)
                return null;
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

        public static Topic AddTopic(string name, int courseId)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Topics.Where(p => p.Name == name && p.CourseId == courseId).Count() != 0)
                return null;
            Topic newTopic = new Topic();
            newTopic.Name = name;
            newTopic.CourseId = courseId;
            db.Topics.Add(newTopic);
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
            return newTopic;
        }

        //add manytomany to db

        public static CourseTeacher BindTeacherToCourse(int teacherId, int courseId)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.CourseTeachers.Where(p => p.TeacherId == teacherId && p.CourseId == courseId).Count() != 0)
                return null;
            CourseTeacher newCourseTeacher = new CourseTeacher();
            newCourseTeacher.CourseId = courseId;
            newCourseTeacher.TeacherId = teacherId;
            db.CourseTeachers.Add(newCourseTeacher);
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
            return newCourseTeacher;
        }

        public static CourseStudent BindStudentToCourse(int studentId, int courseId)
        {
            CoursesEntities db = new CoursesEntities();
            //if (db.CourseStudents.Where(p => p.StudentId == studentId && p.CourseId == courseId).Count() != 0)
            //    return null;
            CourseStudent newCourseStudent = new CourseStudent();
            newCourseStudent.CourseId = courseId;
            newCourseStudent.StudentId = studentId;
            newCourseStudent.IsPaid = false;
            db.CourseStudents.Add(newCourseStudent);
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
            return newCourseStudent;
        }

        //delete from db

        public static bool DelTeacher(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Teacher teacher = db.Teachers.Find(id);
            if (teacher!=null)
            {
                db.Teachers.Remove(teacher);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true; 
                }
                catch(Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static bool DelSchool(int id)
        {
            CoursesEntities db = new CoursesEntities();
            School school = db.Schools.Find(id);
            if (school != null)
            {
                db.Schools.Remove(school);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static bool DelSubject(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Subject subject = db.Subjects.Find(id);
            if (subject != null)
            {
                db.Subjects.Remove(subject);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;

        }

        public static bool DelStudent(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Student student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static bool DelCourse(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Course course = db.Courses.Find(id);
            if (course != null)
            {
                db.Courses.Remove(course);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static bool DelTopic(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Topic topic = db.Topics.Find(id);
            if (topic != null)
            {
                db.Topics.Remove(topic);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;

        }

        //delete manytomany from db

        public static bool DelBindTeacherToCourse(int id)
        {
            CoursesEntities db = new CoursesEntities();
            CourseTeacher courseTeacher = db.CourseTeachers.Find(id);
            if (courseTeacher != null)
            {
                db.CourseTeachers.Remove(courseTeacher);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        public static bool DelBindStudentToCourse(int id)
        {
            CoursesEntities db = new CoursesEntities();
            CourseStudent courseStudent = db.CourseStudents.Find(id);
            if (courseStudent != null)
            {
                db.CourseStudents.Remove(courseStudent);
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
                catch (Exception)
                {
                    db.Dispose();
                    return false;
                }
            }
            return false;
        }

        //edit db

        public static Teacher EditTeacher(int id, string name)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Teachers.Where(p => p.Name == name).Count() != 0)
                return null;
            Teacher teacher = db.Teachers.Find(id);
            if (teacher!=null)
            {
                teacher.Name = name;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return teacher;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static School EditSchool(int id, string name)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Schools.Where(p => p.Name == name).Count() != 0)
                return null;
            School school = db.Schools.Find(id);
            if (school != null)
            {
                school.Name = name;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return school;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static Subject EditSubject(int id, string name)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Subjects.Where(p => p.Name == name).Count() != 0)
                return null;
            Subject subject = db.Subjects.Find(id);
            if (subject != null)
            {
                subject.Name = name;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return subject;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static Student EditStudent(int id, string name, int group, int schoolId)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Students.Where(p => p.Name == name && p.GroupN == group && p.SchoolId == schoolId).Count() != 0)
                return null;
            Student student = db.Students.Find(id);
            if (student != null)
            {
                student.Name = name;
                student.GroupN = group;
                student.SchoolId = schoolId;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return student;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static Course EditCourse(int id, decimal cost, int duration, int subjectId)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Courses.Where(p => p.SubjectId == subjectId && p.Duration == duration && p.Cost == cost).Count() != 0)
                return null;
            Course course = db.Courses.Find(id);
            if (course != null)
            {
                course.Cost = cost;
                course.Duration = duration;
                course.SubjectId = subjectId;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return course;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        public static Topic EditTopic(int id, string name, int courseId)
        {
            CoursesEntities db = new CoursesEntities();
            if (db.Topics.Where(p => p.Name == name && p.CourseId == courseId).Count() != 0)
                return null;
            Topic topic = db.Topics.Find(id);
            if (topic != null)
            {
                topic.Name = name;
                topic.CourseId = courseId;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return topic;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
        }

        //edit manytomany db

        public static CourseStudent EditBindStudentToCourse(int id, bool isPaid, int? sertificateNumber)
        {
            CoursesEntities db = new CoursesEntities();
            CourseStudent courseStudent = db.CourseStudents.Find(id);
            if (courseStudent != null)
            {
                courseStudent.IsPaid = isPaid;
                courseStudent.SertificateNumber = sertificateNumber;
                try
                {
                    db.SaveChanges();
                    db.Dispose();
                    return courseStudent;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException)
                {
                    db.Dispose();
                    return null;
                }
            }
            return null;
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

        public static List<Student> GetStudents()
        {
            CoursesEntities db = new CoursesEntities();
            List<Student> res = db.Students.ToList();
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
                courseStudents.ForEach(p => res.Add(db.CoursesStudentsViews.Where(q => q.StudentId == p.StudentId).First()));
            }
            db.Dispose();
            return res;
        }

        public static List<CoursesStudentsView> GetCourseStudentViews(int studentId)
        {
            List<CoursesStudentsView> res;
            CoursesEntities db = new CoursesEntities();
            res = new List<CoursesStudentsView>();
            db.CoursesStudentsViews.Where(p => p.StudentId == studentId).ToList().ForEach(p => res.Add(p));
            db.Dispose();
            return res;
        }

        public static List<CoursesTeachersView> GetCourseTeachersViews(List<CourseTeacher> courseTeachers = null)
        {
            List<CoursesTeachersView> res;
            CoursesEntities db = new CoursesEntities();
            if (courseTeachers == null)
                res = db.CoursesTeachersViews.ToList();
            else
            {
                res = new List<CoursesTeachersView>();
                courseTeachers.ForEach(p => res.Add(db.CoursesTeachersViews.Where(q => q.TeacherId == p.TeacherId).First()));
            }
            db.Dispose();
            return res;
        }

        public static List<CoursesTeachersView> GetCourseTeachersViews(int teacherId)
        {
            List<CoursesTeachersView> res;
            CoursesEntities db = new CoursesEntities();
            res = new List<CoursesTeachersView>();
            db.CoursesTeachersViews.Where(p=>p.TeacherId == teacherId).ToList().ForEach(p=>res.Add(p));
            db.Dispose();
            return res;
        }

        //get entity from db

        public static Course GetCourse(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Course res = db.Courses.ToList().Find(p => p.Id == id);
            if (res != null)
            {
                res.Topics = res.Topics.ToList();
                res.CoursesTeachers = res.CoursesTeachers.ToList();
                res.CoursesStudents = res.CoursesStudents.ToList();
                res.Subject.ToString();
            }
            db.Dispose();
            return res;
        }

        public static Teacher GetTeacher(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Teacher res = db.Teachers.ToList().Find(p => p.Id == id);
            if (res != null)
                res.CoursesTeachers = res.CoursesTeachers.ToList();
            db.Dispose();
            return res;
        }

        public static School GetSchool(int id)
        {
            CoursesEntities db = new CoursesEntities();
            School res = db.Schools.ToList().Find(p => p.Id == id);
            if (res!=null)
                res.Students = res.Students.ToList();
            db.Dispose();
            return res;
        }

        public static Subject GetSubject(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Subject res = db.Subjects.ToList().Find(p => p.Id == id);
            if (res != null)
                res.Courses = res.Courses.ToList();
            db.Dispose();
            return res;
        }

        public static Student GetStudent(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Student res = db.Students.ToList().Find(p => p.Id == id);
            if (res != null && res.School !=null)
                res.School.ToString();
            db.Dispose();
            return res;
        }

        public static Topic GetTopic(int id)
        {
            CoursesEntities db = new CoursesEntities();
            Topic res = db.Topics.ToList().Find(p => p.Id == id);
            if (res != null)
                res.Cours.ToString();
            db.Dispose();
            return res;
        }

        public static CourseStudent GetCourseStudent(int id)
        {
            CoursesEntities db = new CoursesEntities();
            CourseStudent res = db.CourseStudents.ToList().Find(p => p.Id == id);
            if (res != null)
            {
                res.Cours.ToString();
                res.Student.ToString();
            }
                
            db.Dispose();
            return res;

        }

    }
}
