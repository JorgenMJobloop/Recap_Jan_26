public class Manager : Employee
{
    public Manager(double salary) : base(salary)
    {

    }

    public void IncreaseSalary(double amount)
    {
        Salary += amount;
    }
}