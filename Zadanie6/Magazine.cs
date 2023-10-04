internal class Magazine
{
    private string name;
    private string address;
    private string profileDescription;
    private string phoneNumber;
    private string email;

    public void InputData()
    {
        Console.Write("Введите название магазина: ");
        name = Console.ReadLine();

        Console.Write("Введите адрес магазина: ");
        address = Console.ReadLine();

        Console.Write("Введите описание профиля магазина: ");
        profileDescription = Console.ReadLine();

        Console.Write("Введите контактный телефон магазина: ");
        phoneNumber = Console.ReadLine();

        Console.Write("Введите контактный email магазина: ");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Название магазина: {name}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Описание профиля магазина: {profileDescription}");
        Console.WriteLine($"Контактный телефон: {phoneNumber}");
        Console.WriteLine($"Контактный email: {email}");
    }

    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public string GetEmail()
    {
        return email;
    }
}