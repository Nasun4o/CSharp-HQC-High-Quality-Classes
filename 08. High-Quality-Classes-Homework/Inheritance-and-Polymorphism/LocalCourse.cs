﻿namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : AbstractCourse
    {

        public LocalCourse(string name)
            : base(name)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab { get; set; }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }

}
    //{
    //    public string Name { get; set; }
    //    public string TeacherName { get; set; }
    //    public IList<string> Students { get; set; }
    //    public string Lab { get; set; }

    //    public LocalCourse(string name)
    //    {
    //        this.Name = name;
    //        this.TeacherName = null;
    //        this.Students = new List<string>();
    //        this.Lab = null;
    //    }

    //    public LocalCourse(string courseName, string teacherName)
    //    {
    //        this.Name = courseName;
    //        this.TeacherName = teacherName;
    //        this.Students = new List<string>();
    //        this.Lab = null;
    //    }

    //    public LocalCourse(string courseName, string teacherName, IList<string> students)
    //    {
    //        this.Name = courseName;
    //        this.TeacherName = teacherName;
    //        this.Students = students;
    //        this.Lab = null;
    //    }

