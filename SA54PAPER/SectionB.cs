using System;
namespace SA54PAPER
{
    public class Person
    {
        private string email = String.Empty;
        private string name = String.Empty;
        private int year;
        public Person(string e,string n,int y = -1)
        {
            Email = e;
            Name = n;
            Year = y;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }

        public override string ToString()
        => Year == -1 ? $"Email:{Email}, Name:{Name}" : $"Email:{Email}, Name:{Name}, Year Of Birth: {Year}";

        public void Dispaly() => Console.WriteLine(this.ToString());
    }

    public class Employee : Person
    {
        private double salary;
        public Employee(string e, string n, int y, double s) : base(e, n, y)
        => Salary = s;
        public double Salary
        {
            get => salary;
            set => salary = value;
        }
        public override string ToString()
        => $"Email:{Email}, Name:{Name}, Year Of Birth: {Year}, Salary: {Salary}";
    }

    public class Faculty : Employee
    {
        private bool tenure;
        public Faculty(string e, string n, int y, double s,bool t) : base(e, n, y, s)
        =>Tenure = t;
        public bool Tenure
        {
            get => tenure;
            set => tenure = value;
        }
        public override string ToString()
        => $"Email:{Email}, Name:{Name}, Year Of Birth: {Year}, Salary: {Salary}, Tenure: {Tenure}";

    }

    public class Student : Person
    {
        private string major = string.Empty;
        public Student(string e, string n, int y, string m) : base(e, n, y)
        => Major = m;
        public string Major
        {
            get => major;
            set => major = value;
        }
        public override string ToString()
       => $"Email:{Email}, Name:{Name}, Year Of Birth: {Year}, Major: {Major}";


    }

    public class PersonRecords
    {
        private ICollection<Person> people;

        public PersonRecords()=>People = new List<Person>();

        public ICollection<Person> People
        {
            get => people;
            set => people = value;
        }

        public void Add(Person p) => People.Add(p);

        public void Display()
        {
            foreach (var p in People)
                Console.WriteLine(p.ToString());
        }
    }


}

