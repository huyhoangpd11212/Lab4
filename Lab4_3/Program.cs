using System;
using System.Collections.Generic;

public class studentLab4
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public studentLab4(string id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Khởi tạo danh sách các đối tượng Student
        List<studentLab4> list = new List<studentLab4>
        {
            new studentLab4("1", "Bảo Trâm", 13),
            new studentLab4("2", "Quốc Trung", 12),
            new studentLab4("3", "Huyền Trang", 15),
            new studentLab4("4", "Gia Lâm", 20),
            new studentLab4("5", "Vân Anh", 16)
        };

        // a/ Sử dụng LINQ Query Syntax
        var querySyntax = from student in list
                          where student.Age > 12 && student.Age < 20
                          select student;

        Console.WriteLine("LINQ Query Syntax:");
        foreach (var student in querySyntax)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // b/ Sử dụng LINQ Method Syntax
        var methodSyntax = list.Where(student => student.Age > 12 && student.Age < 20);

        Console.WriteLine("\nLINQ Method Syntax:");
        foreach (var student in methodSyntax)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}
