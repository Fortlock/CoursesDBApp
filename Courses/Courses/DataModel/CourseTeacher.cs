//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Courses.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseTeacher
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Nullable<int> TeacherId { get; set; }
    
        public virtual Course Cours { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
