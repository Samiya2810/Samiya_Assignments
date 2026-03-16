namespace StudentEnrollment1.ViewModels
{
    public class StudentDetails
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public List<StudentCourse> Courses { get; set; }
    }
}

