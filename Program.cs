
//Criar Lista
using ListEmplyee;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

var employees = CreateList();

//Mostrar Lista
ShowList(employees);

//editar Lista
employees = UpdateSalary(employees);

//Mostrar lista
Console.WriteLine("Update list of employees: ");
ShowList(employees);



    static List<Employee> CreateList()
{
    var employees = new List<Employee>();

    Console.WriteLine("How many employee will be registreded? ");
    var amount = Console.ReadLine();

    for(int i =0; i < int.Parse(amount); i++)
    {
        Console.WriteLine($"Employee #{1} ");

        Console.WriteLine("Id: ");
        var id = Console.ReadLine();

        Console.WriteLine("Name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Salary: ");
        var salary = Console.ReadLine();

        employees.Add(new Employee(int.Parse(id), name, double.Parse(salary)));
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Employee successfully added!");

       
    }

    return employees;

}

static void ShowList(List<Employee> employees)
{
    foreach(var employee in employees)
    {
        Console.WriteLine($"Employee: {employee.Id} - {employee.Name} - {employee.Salary}");

    }
}

static List<Employee> UpdateSalary(List<Employee> employyes)
{
    Console.WriteLine("Enter the employee ID that will have salary increase: ");
    var id = int.Parse(Console.ReadLine());

    Console.WriteLine("Percentage: ");
    var percentage = double.Parse(Console.ReadLine());

    var employeeIndex = employyes.FindIndex(x => x.Id == id);
    employyes[employeeIndex].IncreaseSalary(percentage);

    return employyes;
}

