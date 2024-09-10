using System;
using System.Collections.Generic;

public abstract class Employee
{

    public int ID { get; set;}
    public string Name { get; set;}

    public Employee(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public abstract void PerformDuties();

}

// Офицант

public class Waiter : Employee{

    public Waiter(string name, int id) : base(name, id)
    {
    }

}
