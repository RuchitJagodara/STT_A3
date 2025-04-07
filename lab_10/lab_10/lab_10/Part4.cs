public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public string getGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 80) return "B";
        else if (Marks >= 70) return "C";
        return "D";
    }

    public static void Main7()
    {
        Student s = new Student("Alice", 101, 85);
        System.Console.WriteLine($"Name: {s.Name}");
        System.Console.WriteLine($"ID: {s.ID}");
        System.Console.WriteLine($"Marks: {s.Marks}");
        System.Console.WriteLine($"Grade: {s.getGrade()}");
    }
}

public class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, int id, double marks, string hostelName)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostelName;
    }

    public static void Main()
    {
        StudentIITGN s = new StudentIITGN("Bob", 202, 93, "Samagam Hostel");
        System.Console.WriteLine($"Name: {s.Name}");
        System.Console.WriteLine($"ID: {s.ID}");
        System.Console.WriteLine($"Marks: {s.Marks}");
        System.Console.WriteLine($"Grade: {s.getGrade()}");
        System.Console.WriteLine($"Hostel: {s.Hostel_Name_IITGN}");
    }
}
