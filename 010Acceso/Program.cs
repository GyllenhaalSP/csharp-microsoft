string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    Console.WriteLine($"Welcome, {(level > 55 ? "Super Admin" : "Admin")} user");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}