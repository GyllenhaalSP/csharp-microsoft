string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;

foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    if (ValidateLength() && ValidateZeroes() && ValidateRange())
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

bool ValidateLength()
{
    return address.Length == 4;
};

bool ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            return false;
        }
    }
    return true;
}

bool ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            return false;
        }
    }
    return true;
}