﻿internal class Journal
{
    private string name;
    private int year;
    private string description;
    private string phone;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введите название журнала: ");
        SetName(Console.ReadLine());

        Console.Write("Введите год основания: ");
        SetYear(int.Parse(Console.ReadLine()));

        Console.Write("Введите описание журнала: ");
        SetDescription(Console.ReadLine());

        Console.Write("Введите контактный телефон: ");
        SetPhone(Console.ReadLine());

        Console.Write("Введите контактный e-mail: ");
        SetEmail(Console.ReadLine());
    }

    public void OutputData()
    {
        Console.WriteLine("Название журнала: " + GetName());
        Console.WriteLine("Год основания: " + GetYear());
        Console.WriteLine("Описание журнала: " + GetDescription());
        Console.WriteLine("Контактный телефон: " + GetPhone());
        Console.WriteLine("Контактный e-mail: " + GetEmail());
    }
}