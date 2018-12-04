using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.DataModel
{
    static class CoursesRequests
    {
        public static bool AddTeacher(string name)
        {
            CoursesEntities db = new CoursesEntities();
            Teacher newTeacher = new Teacher();
            newTeacher.Name = name;
            db.Teachers.Add(newTeacher);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                return false;
            }
            return true;
        }
    }
}
