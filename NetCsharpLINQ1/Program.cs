// See https://aka.ms/new-console-template for more information
using NetCsharpLINQ1;




Employee emp1 = new Employee("John", "Doe", "Smith", "Software Developer", "123-456-7890", "john.doe@email.com", 85000.50);
Employee emp2 = new Employee("Jane", "Smith", "Johnson", "Project Manager", "123-555-7890", "jane.smith@email.com", 95000.00);
Employee emp3 = new Employee("Michael", "Johnson", "Williams", "UX Designer", "123-555-1234", "michael.johnson@email.com", 70000.75);
Employee emp4 = new Employee("Sarah", "Davis", "Brown", "Marketing Specialist", "123-555-5678", "sarah.davis@email.com", 60000.40);
Employee emp5 = new Employee("David", "Miller", "Wilson", "HR Manager", "123-555-9876", "david.miller@email.com", 78000.60);

Firm firm1 = new Firm("TechSolutions", new DateTime(2015, 6, 25), "IT", "John", "Doe", "Smith", 150, "123 Silicon Valley, San Francisco", new Employee[] {emp1, emp2, emp3, emp4, emp5});
Firm firm2 = new Firm("GreenTech", new DateTime(2018, 9, 1), "Environmental Solutions", "Emily", "Johnson", "Lee", 75, "456 Green Street, Austin", new Employee[] { emp1, emp2, emp3 });
Firm firm3 = new Firm("BuildMaster", new DateTime(2000, 3, 12), "Construction", "Michael", "Williams", "Brown", 200, "789 Construction Rd, New York", new Employee[] {  emp3, emp4, emp5 });
Firm firm4 = new Firm("HealthNet", new DateTime(2012, 11, 15), "Healthcare", "Sarah", "Taylor", "Davis", 120, "321 Health Blvd, Chicago", new Employee[] {  emp4, emp5 });
Firm firm5 = new Firm("EduFuture", new DateTime(2010, 1, 30), "Educational Services", "David", "Miller", "Wilson", 50, "654 Academy Street, Boston", new Employee[] {emp5 });

Firm[] firms = { firm1, firm2, firm3, firm4, firm5 };


var selectedFirms = from t in firms
                    select t;
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.Name.Contains("Food"));
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.Profile.ToUpper() == "Marketing");
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.Profile.ToUpper() == "IT" || t.Profile.ToUpper() == "Marketing");
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.CountOfEmployees>100);
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.CountOfEmployees > 100 && t.CountOfEmployees<300);
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.Adress.ToUpper().Contains("LONDON"));
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.HeadLastName=="White");
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

DateTime tempdate = new DateTime(2022,11,19);
selectedFirms = firms.Where(t => t.FirmDate<tempdate);
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

DateTime today = DateTime.Now;
selectedFirms = firms.Where(t => (today - t.FirmDate).Days == 123);
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedFirms = firms.Where(t => t.HeadLastName=="Black" && t.Name.Contains("White"));
foreach (var t in selectedFirms)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

//task2 - реализован в первом задании

//task3

 selectedFirms = firms.Where(t => t.HeadLastName == "Black" && t.Name.Contains("White"));


foreach (var firm in selectedFirms)
{
    Console.WriteLine(firm);  
    foreach (var emp in firm.employees)
    {
        Console.WriteLine(emp);  
    }
    Console.WriteLine();
}

selectedFirms = firms.Where(t => t.HeadLastName == "Black" && t.Name.Contains("White"));
foreach (var firm in selectedFirms)
{
    var selectedEmployees = firm.employees.Where(t => t.Salary > 3000);
    foreach (var t in selectedEmployees)
        Console.WriteLine(t + " ");
    Console.WriteLine();
    Console.WriteLine();
}

foreach (var firm in firms)
{
    var selectedEmployees = firm.employees.Where(t => t.Job =="Manager");
    foreach (var t in selectedEmployees)
        Console.WriteLine(t + " ");
    Console.WriteLine();
    Console.WriteLine();
}

foreach (var firm in firms)
{
    var selectedEmployees = firm.employees.Where(t => t.Phone.StartsWith("23"));
    foreach (var t in selectedEmployees)
        Console.WriteLine(t + " ");
    Console.WriteLine();
    Console.WriteLine();
}

foreach (var firm in firms)
{
    var selectedEmployees = firm.employees.Where(t => t.Email.StartsWith("di"));
    foreach (var t in selectedEmployees)
        Console.WriteLine(t + " ");
    Console.WriteLine();
    Console.WriteLine();
}

foreach (var firm in firms)
{
    var selectedEmployees = firm.employees.Where(t => t.EmployeeName=="Lionel");
    foreach (var t in selectedEmployees)
        Console.WriteLine(t + " ");
    Console.WriteLine();
    Console.WriteLine();
}
