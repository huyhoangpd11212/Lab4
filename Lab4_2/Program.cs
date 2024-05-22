using System;
using System.Collections.Generic;

public class userDataLab4
{
    public string Name { get; set; }
    public int Level { get; set; }

    public userDataLab4(string name, int level)
    {
        Name = name;
        Level = level;
    }
}

class Program
{
    static void Main()
    {
        // Khởi tạo danh sách userData
        List<userDataLab4> list = new List<userDataLab4>
        {
            new userDataLab4("GTA 5", 10),
            new userDataLab4("Genshin Impact", 15),
            new userDataLab4("Gunny", 5),
            new userDataLab4("Liên Minh Huyền Thoại", 100)
        };

        // a/ Xuất thông tin "Name" và "Level"
        var selectedUsers = list.Select(u => new { u.Name, u.Level });
        foreach (var user in selectedUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }

        // b/ Xắp xếp lại danh sách userData theo thứ tự giảm dần "Level"
        var sortedUsers = list.OrderByDescending(u => u.Level);
        Console.WriteLine("\nSorted by Level (Descending):");
        foreach (var user in sortedUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }
    }
}
