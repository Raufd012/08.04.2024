using _08._04._2024.Models;
using System.Text.RegularExpressions;

namespace _08._04._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Rauf", "Dostuyev");

            Student student2 = new Student("Sahib", "Mammadov");
            
            Group group = new System.Text.RegularExpressions.Group("Ap114");

            Group group1 = new System.Text.RegularExpressions.Group("Ab106");

            group1.Addstudent(student);
            group1.Addstudent(student2);

            Group.AddGroup(group1);

            student.GetInfo();

            group.Addstudent(student);
            student2.GetInfo();
            Group.RemoveGroup(2);
        }
    }
}
