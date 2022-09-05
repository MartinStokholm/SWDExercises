namespace ReportGenerator
{
    public class Employee
    {
        public Employee() : this("", 0)
        {
        }

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }
        public uint Salary { get; private set; }
    }
}