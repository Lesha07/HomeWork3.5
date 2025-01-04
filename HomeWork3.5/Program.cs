using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Саша", Surname = "Іваненко", BirthDate = new DateTime(1985, 5, 20), HireDate = new DateTime(2015, 3, 15) },
            new Employee { Name = "Маша", Surname = "Хмельниченко", BirthDate = new DateTime(2000, 7, 10), HireDate = new DateTime(2021, 6, 1) },
            new Employee { Name = "Іван", Surname = "Сидорчук", BirthDate = new DateTime(1978, 2, 14), HireDate = new DateTime(2012, 9, 10) },
            new Employee { Name = "Анна", Surname = "Коваль", BirthDate = new DateTime(1995, 12, 25), HireDate = new DateTime(2018, 1, 5) }
        };
        
        DateTime currentDate = DateTime.Now;
        
        var FilterForYear = employees.Where(e => (currentDate - e.HireDate).TotalDays > 5 * 365);
        
        Console.WriteLine("Співробітники, які працюють у компанії більше 5 років:");
        foreach (var employee in FilterForYear)
        {
            Console.WriteLine(employee);
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime HireDate { get; set; }

    public override string ToString()
    {
        return $"{Name} {Surname}, Дата народження: {BirthDate.ToShortDateString()}, Дата працевлаштування: {HireDate.ToShortDateString()}";
    }
}
