using System;
using System.Collections.Generic;

// класс для сотрудников ресторана
public abstract class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public abstract void PerformDuties(); // Полиморфизм
}

// Официант
public class Waiter : Employee
{
    public Waiter(string name, int id) : base(name, id) { }

    public override void PerformDuties()
    {
        Console.WriteLine($"{Name} обслуживает столики.");
    }

    public void TakeOrder(Order order)
    {
        
    }
}

// Повар
public class Chef : Employee
{
    public Chef(string name, int id) : base(name, id) { }

    public override void PerformDuties()
    {
        Console.WriteLine($"{Name} готовит блюда.");
    }

    public void CookOrder(Order order)
    {
        
    }
}

// Класс блюда
public class MenuItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public MenuItem(string name, string description, decimal price, string category)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
    }

    public void ShowInfo()
    {
        
    }
}

// Класс заказа
public class Order
{
    public int TableNumber { get; set; }
    public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    public Waiter AssignedWaiter { get; set; }

    public void AddMenuItem(MenuItem item)
    {
        Items.Add(item);
    }

    public void ShowOrder()
    {
        
        foreach (var item in Items)
        {
            item.ShowInfo();
        }
    }
}

// Класс столика
public class Table
{
    public int Number { get; set; }
    public bool IsOccupied { get; set; }

    public Table(int number)
    {
        Number = number;
        IsOccupied = false;
    }

    public void Occupy()
    {
        
    }

    public void Free()
    {
        
    }
}

// Класс клиента
public class Customer
{
    public string FullName { get; set; }
    public int CustomerID { get; set; }

    public Customer(string fullName, int customerId)
    {
        FullName = fullName;
        CustomerID = customerId;
    }

    public void MakeOrder(Waiter waiter, Order order)
    {
        
    }
}

// Основной класс ресторана
public class Restaurant
{
    public List<Table> Tables { get; set; } = new List<Table>();
    public List<MenuItem> Menu { get; set; } = new List<MenuItem>();

    public void AddTable(Table table)
    {
        Tables.Add(table);
    }

    public void AddMenuItem(MenuItem item)
    {
        Menu.Add(item);
    }

    public void ProcessOrder(Order order)
    {
        
        order.ShowOrder();
    }
}

// Программа
class Program
{
    static void Main(string[] args)
    {
    
    }
}
