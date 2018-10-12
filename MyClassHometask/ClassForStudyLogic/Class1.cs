using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudyLogic
{
    public class Student
    {
        public string StudName { get; set; }
        public Group StudGroup { get; set; }
        public string CheckMyInfo()
        {
            string AllInfo;
            AllInfo = "Group name is " + StudGroup.GroupName + "And your teacher is " + StudGroup.GroupTeach.TeachName;
            return AllInfo;
        }
        public Student(string studname, Group studgroup)
        {
            StudName = studname;
            StudGroup = studgroup;
        }
    }
    public class Teacher
    {
        public string TeachName { get; set; }
        public string TeachStatus { get; set; }
        public Group TeachGroup { get; set; }
        public string CheckMyGroup()
        {
            string AllInfo;
            AllInfo = "Group name is " + TeachGroup.GroupName + "And All of students are " + TeachGroup.StudentsInGr;
            return AllInfo;
        }
        public Teacher(string teachername, string teacherstatus, Group teachergroup)
        {
            TeachName = teachername;
            TeachStatus = teacherstatus;
            TeachGroup = teachergroup;
        }
    }
    public class Group
    {
        public Student[] StudentsInGr { get; set; }
        public Teacher GroupTeach { get; set; }
        public string GroupName { get; set; }
        public int GroupLimit { get; set; }
        public Student[] AddNewStudent(Student NewStud)
        {
            for (int i = 0; i < StudentsInGr.Length; i++)
            {
                if (StudentsInGr[i] == null)
                {
                    StudentsInGr[i] = NewStud;
                    break;
                }
            }
            return StudentsInGr;
        }
        public Student[] DeleteStudent(Student DelStud)
        {
            for (int i = 0; i < StudentsInGr.Length; i++)
            {
                if (StudentsInGr[i] == DelStud)
                {
                    StudentsInGr[i] = null;
                }
            }
            return StudentsInGr;
        }
        public Group(Student[] studentingr, Teacher groupteach, string groupname, int grouplimit)
        {
            StudentsInGr = studentingr;
            GroupTeach = groupteach;
            GroupName = groupname;
            GroupLimit = grouplimit;
        }
    }
}
