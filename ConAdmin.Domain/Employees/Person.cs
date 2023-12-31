﻿namespace ConAdmin.Domain.Employees;

public abstract class Person : EntityBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Initials { get; set; }
    protected Person(object? key, string firstName, string lastName) : base(key)
    {
        FirstName = firstName;
        LastName = lastName;
        Initials = string.Empty;
    }
}