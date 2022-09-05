namespace ReportGeneratorLib
{
    public class Employee 
    {
       
        public Employee() : this("", 0, 0)  // Default initialization
        {}

        public Employee(string name, uint salary, int age)
        {
            Name = name;
            Salary = salary;
            Age = age;
        }

        public int Age { get; private set; }
        public string Name { get; private set; }
        public uint Salary { get; private set; }
    
    }
}