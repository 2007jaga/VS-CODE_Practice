
namespace CMS.UI.Models {

    public class Student
    {

        public int _StudentId;
        public string _Name;
        public string _Age;
        public Student(int StudentId, string Name, string Age)
        {
            _Name = Name;
            _Age = Age;
            _StudentId = StudentId;
        }
    }
}