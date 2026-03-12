namespace MVCExampleDemo.Models
{
    public class Employee
    {
        public int EmployeeID {  get; set; }
        public string? EmpName {  get; set; }

        public int Salary {  get; set; }

        public string? ImageUrl {  get; set; }

        public int DeptID {  get; set; }
        public Dept? Dept { get; set; }
        
    }
}
