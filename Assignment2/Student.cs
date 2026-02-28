namespace Assignment2
{
    public class Student
    {
        public int StudentID { get; }
        public string Name { get; }
        public string Course { get; }
        public int Grade { get; }

        public Student(int studentID, string name, string course, int grade)
        {
            StudentID = studentID;
            Name = name;
            Course = course;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{StudentID},{Name},{Course},{Grade}";
        }
    }
}